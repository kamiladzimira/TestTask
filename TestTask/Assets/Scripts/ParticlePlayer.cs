using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem _particleSystem;

    public void Play()
    {
        ParticleSystem newParticleSystem = Instantiate(_particleSystem, transform.position, Quaternion.identity, null);
        newParticleSystem.Play();
    }
}
