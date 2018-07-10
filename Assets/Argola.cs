using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Argola : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(14 * Time.deltaTime, 20 * Time.deltaTime, 5 * Time.deltaTime);
	}
}
