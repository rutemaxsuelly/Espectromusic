using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Pontuacao : MonoBehaviour {
    private static Pontuacao instance;
    public static Pontuacao GetInstance{
    get
        {
            if(instance == null)
                {
                    instance = FindObjectOfType<Pontuacao>();
                    if( instance == null)
                    {
                        GameObject go = new GameObject();
                        go.name = "Pontuacao";
                        instance = go.AddComponent<Pontuacao>();
                        DontDestroyOnLoad(go);
                    }
                }
            return instance;
        }
    }

    private void Awake() {
        if (instance != null) {
            Destroy(gameObject);
        } else { 
            instance = this;
            }
    }


    public int score = 0; // Essa variável será a mesma, independente de quem tiver usando a instancia dessa classe

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
        score++;
        AtualizarPontos();
    }
}
