using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LibPDBinding;

/**
 * @jaderxnet
 * Esta classe é responsável por controlar o jogador
 * */
public class PdMicrofoneControladorJogador : MonoBehaviour {
	
	//Inicialíza as variáveis não inializadas
    void Start()
    {
       
    }

	//Atualizações fixas
    void FixedUpdate()
    {
		
    }
		
	//Atualizações dinâmicas
	void Update () {
        LibPD.SendFloat ("microfone", 0);
	}
}
