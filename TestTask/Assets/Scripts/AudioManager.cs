using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    [SerializeField] private AudioSource hitSoundSource;
    [SerializeField] private AudioSource explodeSoundSource;
    [SerializeField] private AudioSource shootSoundSource;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public static AudioManager GetInstance()
    {
        return instance;
    }
    public void PlayHitSound()
    {
        hitSoundSource.Play();
    }

    public void PlayExplodeSound()
    {
        explodeSoundSource.Play();
    }

    public void PlayShootSound()
    {
        shootSoundSource.Play();
    }
}




