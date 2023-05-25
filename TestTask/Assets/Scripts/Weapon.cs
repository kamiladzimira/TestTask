using System;
using UnityEngine;
using UnityEngine.Events;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private WeaponData _weaponData;
    public WeaponData WeaponData => _weaponData;
    public UnityEvent OnFire;
    public void OnShoot()
    {
        OnFire?.Invoke();
        Bullet currentBullet = Instantiate(_bullet, transform.position, transform.rotation);
        currentBullet.Setup(_weaponData.Damage, _weaponData.EffectiveAgainst);
    }
}
