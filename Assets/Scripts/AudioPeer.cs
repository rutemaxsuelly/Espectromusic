using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class AudioPeer : MonoBehaviour
{
    AudioSource _audioSource;
    public static float[] _samples = new float[512];

    //Microphone input
    public AudioClip _audioClip;
    public bool _useMicrophone = true;
    public string _selectedDevice;
	public AudioMixerGroup audioMixerMaster, audioMixerMicrofone;

    // Use this for initialization
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        //Microfone input
        if (_useMicrophone)
        {
            if (Microphone.devices.Length > 0)
            {
                _selectedDevice = Microphone.devices[0].ToString();
				_audioSource.outputAudioMixerGroup = audioMixerMicrofone;
                _audioSource.clip = Microphone.Start(_selectedDevice, true, 100, AudioSettings.outputSampleRate);
            }
            else
            {
                _useMicrophone = false;
            }
        }
        if (!_useMicrophone)
        {
			_audioSource.outputAudioMixerGroup = audioMixerMaster;
            _audioSource.clip = _audioClip;
        }

        _audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
    }

    void GetSpectrumAudioSource()
    {
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
    }

}
