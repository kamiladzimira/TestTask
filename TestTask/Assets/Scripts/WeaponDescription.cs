using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponDescription : MonoBehaviour
{
    [SerializeField] private Weapon _weapon;
    [SerializeField] private TextMeshProUGUI _weaponDesc;
    private IReadOnlyList<MaterialData> EffectiveAgainst => _weapon.WeaponData.EffectiveAgainst;

    private void OnEnable()
    {
        SetDescription();
    }

    private void SetDescription()
    {
        string description = _weapon.WeaponData.Name;
        description += "\neffective against:";
        for (int i = 0; i < EffectiveAgainst.Count; i++)
        {
            description += "\n- " + _weapon.WeaponData.EffectiveAgainst[i].Name;
        }
        _weaponDesc.text = description;
    }
}
