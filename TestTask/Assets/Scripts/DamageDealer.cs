using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    private IReadOnlyList<MaterialData> _effectiveAgainst;
    private int _damage;

    public void Setup(int damage, IReadOnlyList<MaterialData> effectiveAgainst)
    {
        _damage = damage;
        _effectiveAgainst = effectiveAgainst;
    }

    private void OnTriggerEnter(Collider collision)
    {
        DamageReceiver _damageReceiver = collision.GetComponent<DamageReceiver>();
        if (_damageReceiver == null)
        {
            return;
        }
        _damageReceiver.TryToGetDamage(_damage, _effectiveAgainst);
        Destroy(gameObject);
    }
}
