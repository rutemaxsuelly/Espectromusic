using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaciarCubos : MonoBehaviour {

    public GameObject _SampleCuberPrefab;
    GameObject[] _sampleCube = new GameObject[512];

    public float _maxscale;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {

            GameObject _instanceSampleCube = (GameObject)Instantiate(_SampleCuberPrefab);
            _instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "SampleCube" + i;
            this.transform.position = new Vector3(i % 10 * 15, 0, i/5 * 20);
            _instanceSampleCube.transform.position = Vector3.forward * 10;
            _sampleCube[i] = _instanceSampleCube;
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 50; i++){
            if (_sampleCube != null) { 
                _sampleCube[i].transform.localScale = new Vector3 (10,(AudioPeer._samples[i] * _maxscale)+ 2 , 10);
            }

        }


    }
}

