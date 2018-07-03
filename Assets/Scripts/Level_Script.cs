using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level_Script : MonoBehaviour {

      public void LoadScene ( string nome){

        SceneManager.LoadScene(nome);
    }

    public void QuitGame()
    {

        Application.Quit();

    }
	
}
