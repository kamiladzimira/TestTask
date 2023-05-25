using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    public static GameManager GetInstance()
    {
        return instance;
    }

    public void PlayHitSound()
    {
        AudioManager.GetInstance().PlayHitSound();
    }

    public void PlayExplodeSound()
    {
        AudioManager.GetInstance().PlayExplodeSound();
    }

    public void PlayShootSound()
    {
        AudioManager.GetInstance().PlayShootSound();
    }
}
