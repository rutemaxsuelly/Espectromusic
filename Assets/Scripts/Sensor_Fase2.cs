using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sensor_Fase2 : MonoBehaviour {
    void OnTriggerEnter(Collider hit)
    {
		Debug.Log (" Colidiu com " + hit.tag);

        if (hit.tag == "Play") ;
        {

			SceneManager.LoadScene(2);

        }
    }

}
