using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] audioClip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolumeControl(float volume)
    {
        audioSource.volume = volume;
    }

    public void SoundCall(string name)
    {
        switch (name)
        {
            case "Siren": audioSource.clip = audioClip[0];
                audioSource.Play();
                break;
            case "Explosion": audioSource.clip = audioClip[1];
                audioSource.Play();
                break;
            case "Magic": audioSource.clip = audioClip[2];
                audioSource.Play();
                break;
        }
    }
}
