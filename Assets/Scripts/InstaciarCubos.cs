using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaciarCubos : MonoBehaviour {

    public GameObject _SampleCuberPrefab;
    GameObject[] _sampleCube = new GameObject[50];

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
           // this.transform.position = new Vector3(i % 10 * 5, 0, i / 5 * 8);
            this.transform.position = new Vector3(i % 10 * 5, -5, i / 5 * 9);
            _instanceSampleCube.transform.position = Vector3.forward * 6;
            _sampleCube[i] = _instanceSampleCube;
        }

        // 0/5 * 5 = 0
        // 1/5 * 5 = 1
        // 2/5 * 5 = 2
        // 2/3 * 5 = 3,3


    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 50; i++){
            if (_sampleCube != null) { 
                _sampleCube[i].transform.localScale = new Vector3 (4,(AudioPeer._samples[i] * _maxscale)+ 2 ,4);
            }

        }


    }
}

