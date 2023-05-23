using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    private MaterialType _materialType;
    private Obstacle _obstacle;
    private int _damage;

    public void Setup(MaterialType materialType, int damage)
    {
        _materialType = materialType;
        _damage = damage;
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
    }
}
