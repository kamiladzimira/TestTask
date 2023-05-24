using TMPro;
using UnityEngine;

public class DamageReceiverDescription : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _materialDesc;
    [SerializeField] private DamageReceiver _damageReceiver;

    private void OnEnable()
    {
        SetDescription();
    }

    private void SetDescription()
    {
        string description = _damageReceiver.MaterialData.Name;
        _materialDesc.text = description;
    }
}
