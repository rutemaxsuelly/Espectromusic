using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetaItens : MonoBehaviour {

	public Pontuacao pontuacao ;

	// Use this for initialization
	void Start () {
		pontuacao = FindObjectOfType<Pontuacao>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter (Collider other)
    {
        other.gameObject.SetActive(false);
		pontuacao.GanharPontos();
    }
}
