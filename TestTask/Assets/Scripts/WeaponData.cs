using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData", menuName = "ScriptableObjects/WeaponData")]
public class WeaponData : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private int _damage;
    [SerializeField] private List<MaterialData> _effectiveAgainst;

    public string Name => _name;
    public int Damage => _damage;
    public IReadOnlyList<MaterialData> EffectiveAgainst => _effectiveAgainst;
}
