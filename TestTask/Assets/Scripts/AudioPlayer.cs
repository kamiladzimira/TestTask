using System.Collections;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;
    [SerializeField]
    private AudioClip _clip;

    public void Play()
    {
        GameManager.GetInstance().StartCoroutine(PlayAudioAndDestroy()) ;
    }

    private IEnumerator PlayAudioAndDestroy()
    {
        AudioSource newAudioSource = Instantiate(_audioSource, transform.position, Quaternion.identity, null);
        newAudioSource.clip = _clip;
        newAudioSource.Play();
        float destroyDelay = newAudioSource.clip.length;
        yield return new WaitForSeconds(destroyDelay);
        Destroy(newAudioSource);
    }
}
