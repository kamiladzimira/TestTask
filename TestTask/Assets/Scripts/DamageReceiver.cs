using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DamageReceiver : MonoBehaviour
{
    [SerializeField] private MaterialData _materialData;
    [SerializeField] private HealthController _healthController;
    public UnityEvent OnGetHit;
    public MaterialData MaterialData => _materialData;

    public void TryToGetDamage(int damage, IReadOnlyList<MaterialData> effectiveAgainst)
    {
        bool canDealDamage = false;
        foreach (MaterialData materialData in effectiveAgainst)
        {
            if (materialData.Type == _materialData.Type)
            {
                canDealDamage = true;
                break;
            }
        }
        if (canDealDamage)
        {
            OnGetHit?.Invoke();
            _healthController.GetDamage(damage);
        }
    }
}
