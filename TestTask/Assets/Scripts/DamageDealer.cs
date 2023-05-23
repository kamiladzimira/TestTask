using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private int _damage;
    private MaterialType _materialType;
    private Obstacle _obstacle;

    public void Setup(MaterialType materialType)
    {
        this._materialType = materialType;
    }

    private void OnTriggerEnter(Collider collision)
    {
        HealthController healthController = collision.GetComponent<HealthController>();
        _obstacle = collision.GetComponent<Obstacle>();
        if (healthController == null)
        {
            return;
        }
        if (_materialType == _obstacle.MaterialType)
        {
            healthController.GetDamage(_damage);
        }
        Destroy(gameObject);
        return;
    }
}
