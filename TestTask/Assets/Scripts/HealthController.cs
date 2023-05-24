using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] private float _healthValue;
 
    public void GetDamage(float value)
    {
        if (_healthValue > 0)
        {
            Debug.Log(_healthValue);
            _healthValue -= value;
            if (_healthValue <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
