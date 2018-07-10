using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Pontuacao : MonoBehaviour {

    public static int score = 0; // Essa variável será a mesma, independente de quem tiver usando a instancia dessa classe

    public Text textPontos;

    void Start()
    {
        AtualizarPontos();
    }


    void AtualizarPontos(){ 

        textPontos.text = "Score: " + score; 
	}

    public void GanharPontos()
    {
 
        Pontuacao.score++;
        AtualizarPontos();
    }
}
