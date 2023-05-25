using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] private float _healthValue;
    public UnityEvent OnDied;
    public void GetDamage(float value)
    {
        if (_healthValue > 0)
        {
            _healthValue -= value;
            if (_healthValue <= 0)
            {
                OnDied?.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
