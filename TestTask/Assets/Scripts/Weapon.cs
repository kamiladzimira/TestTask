using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private WeaponData _weaponData;

    public void OnFire()
    {
        Bullet currentBullet = Instantiate(_bullet, transform.position, transform.rotation);
        currentBullet.Setup(_weaponData.Damage, _weaponData.EffectiveAgainst);
    }
}
