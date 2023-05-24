using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    private IReadOnlyList<MaterialData> _effectiveAgainst;
    private DamageReceiver _damageReceiver;
    private int _damage;

    public void Setup(int damage, IReadOnlyList<MaterialData> effectiveAgainst)
    {
        _damage = damage;
        _effectiveAgainst = effectiveAgainst;
    }

    private void OnTriggerEnter(Collider collision)
    {
        HealthController healthController = collision.GetComponent<HealthController>();
        _damageReceiver = collision.GetComponent<DamageReceiver>();
        if (healthController == null)
        {
            return;
        }
        bool canDealDamage = false;
        foreach (MaterialData materialData in _effectiveAgainst)
        {
            if (materialData.Type == _damageReceiver.MaterialData.Type)
            {
                canDealDamage = true;
                break;
            }
        }
        if (canDealDamage)
        {
            healthController.GetDamage(_damage);
        }
        Destroy(gameObject);
    }
}
