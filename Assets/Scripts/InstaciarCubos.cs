using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaciarCubos : MonoBehaviour {

    public GameObject _SampleCuberPrefab;
    GameObject[] _sampleCube = new GameObject[50];

    public float _maxscale;
    Material material;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            material = _SampleCuberPrefab.GetComponent<MeshRenderer>().materials[0];
            GameObject _instanceSampleCube = (GameObject)Instantiate(_SampleCuberPrefab);
            _instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "SampleCube" + i;
             this.transform.position = new Vector3(i % 10 * 5, 0, i / 5 * 10);
            _instanceSampleCube.transform.position = Vector3.forward * 6;
            _sampleCube[i] = _instanceSampleCube;
        }

    }

    // Update is called once per frame
    void Update()
    {
      int variacaoDeCor = 5;
        Color color = new Color((AudioPeer._samples[0]* variacaoDeCor), (AudioPeer._samples[0]* variacaoDeCor), (AudioPeer._samples[0]* variacaoDeCor));
        material.SetColor("_EmissionColor", color);
        for (int i = 0; i < 50; i++){
            if (_sampleCube != null) {
                _sampleCube[i].transform.localScale = new Vector3 (4,(AudioPeer._samples[i] * _maxscale)+ 2 ,4);
            }

        }


    }
}
