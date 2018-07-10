using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	[RequireComponent (typeof (Light))]
	public class LightAudio : MonoBehaviour {
		public int band;
		public float startScale, maxScale;
		Light light;
		// Use this for initialization
		void Start () {
			light = GetComponent<Light>();
		}

		// Update is called once per frame
		void Update () {
			light.intensity = (AudioPeer._samples[band] * (maxScale - startScale) + startScale);
		}
	}
