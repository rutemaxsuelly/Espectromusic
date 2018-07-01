using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour {

    public int _band;
    public float _starScale, _scaleMultiplier;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    

       transform.localScale= new Vector3(transform.localScale.x, (AudioPeer._FreqBand[_band] * _scaleMultiplier)+ _starScale , transform.localScale.z);
		
	}
}
