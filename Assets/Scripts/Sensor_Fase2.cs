using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sensor_Fase2 : MonoBehaviour {
    void OntriggerEnter(Collider hit)
    {

        if (hit.tag == "Player") ;
        {

            SceneManager.LoadScene(3);

        }
    }

}
