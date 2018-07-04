using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esta classe é para capturar microfone e gerar musica pelo instrumentista;
public class Microfone: MonoBehaviour {
    public AudioSource audioSource;
    float[] samples;
    public int partes = 1024;
    // Use this for initialization
    void Start()
    {
        samples = new float[partes];

        audioSource.clip = Microphone.Start(Microphone.devices[0], true, 100, 44100);
        audioSource.Play();
    }

    float Volume()
    {
        float volume = 0;
        if (audioSource.isPlaying)
        {
            for (int canal = 0; canal < 2; canal++)
            {
                audioSource.GetOutputData(samples, canal);
                for (int i = 0; i < partes; i++)
                {
                    volume += Mathf.Abs(samples[i]);
                }
            }
            volume = volume / partes;
        }
        return volume;
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = transform.parent.position - transform.up * Volume();

    }
}


