using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private MaterialType _materialType;
    [SerializeField] private int _damage;

    public void OnFire()
    {
        Bullet currentBullet = Instantiate(_bullet, transform.position, transform.rotation);
        currentBullet.Setup(_materialType, _damage);
    }
}
