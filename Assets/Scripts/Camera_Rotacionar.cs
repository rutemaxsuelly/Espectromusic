using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Rotacionar : MonoBehaviour {

    public GameObject Player;
    public Vector3 distancia;

	// Use this for initialization
	void Start () {
        distancia = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {

        distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * distancia;
        transform.position = Player.transform.position + distancia;
        transform.LookAt(Player.transform.position);

        Vector3 copiaRotation = new Vector3(0, transform.eulerAngles.y, 0);





	}
}
