using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LibPDBinding;

/**
 * @jaderxnet
 * Esta classe é responsável por controlar o jogador
 * */
public class ControladorJogador : MonoBehaviour {

    //Criado para limitar a rotação da câmera para 90º
    public GameObject referencia;

	//Corpo Rígido associado ao objeto controlado pelo jogador
    public Rigidbody rb;
	//Fator de Velocidade usado para movimentações
	public float speedFactor = 100f;
	//Velocidade máxma do jogador
	public float audiofactor = 0.001f;
	//Velocidade máxma do jogador
	public float maxSpeedJump = 10f;

	//Fator usado para saltos
	public float jumpFactor = 10f;
	//Escala maxima de notas geradas
	public float scale = 100f;
	//Frequência básica para notas geradas
	private int basicFrequency = 60;
	private bool isJump = false;
	//Inicialíza as variáveis não inializadas
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	//Atualizações fixas
    void FixedUpdate()
    {
		//Captura a entrada de controle Horizontal, usando por padrão setas direcionais direita e esquerda e retornando valores de -1 a 1;
        float moveHorizontal = Input.GetAxis("Horizontal");
		//Captura a entrada de controle Vertical, usando por padrão setas direcionais para cima e para baixo e retornando valores entre -1 e 1; 
        float moveVertical = Input.GetAxis("Vertical");
		//Captura a entrada de salto, usando por padrão o espaço e retornano 0 ou 1;
		float jump = Input.GetAxis("Jump");

		//Atualiza as velociades Horizontal e Vertical
		Vector3 direcao = new Vector3 (moveHorizontal, 0, moveVertical);
		rb.AddForce (direcao * speedFactor);
		//float speedH = moveHorizontal * speedFactor * Time.deltaTime;
		//float speedV = moveVertical * speedFactor * Time.deltaTime;
		//rb.velocity = new Vector3 (speedH, rb.velocity.y, speedV);

		//Aplica uma velocidade vertical se um pulo for executado
		if (!isJump && jump > 0) {
			isJump = true;
			rb.velocity = new Vector3(rb.velocity.x, jump * jumpFactor, rb.velocity.z);
		}

		//Se o jogador chegar perto do chão, já pode pular novamente
		if (rb.position.y < 1) {
			isJump = false;
		}
    }
		
	//Atualizações dinâmicas
	void Update () {
		//Toca uma nota de acordo com a magnitude da velocidade
		float pitch = GetPitch(rb.velocity.sqrMagnitude * audiofactor);
		LibPD.SendFloat ("numero", pitch);
	}

	//Retorna um float calculado com base na frequencia basica, aceleração e escala
	float GetPitch (float aceleracao) {
		return scale * aceleracao + basicFrequency;
	}
}
