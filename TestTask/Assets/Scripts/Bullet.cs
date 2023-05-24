using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private float _lifeTime = 6;
    [SerializeField] private DamageDealer _damageDealer;

    private float _timer = 0;

    public void Setup(int damage, IReadOnlyList<MaterialData> effectiveAgainst)
    {
        _damageDealer.Setup(damage, effectiveAgainst);
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        MoveBullet(_speed);
        if (_timer > _lifeTime)
        {
            Destroy(gameObject);
            _timer = 0;
        }
    }

    private void MoveBullet(int speed)
    {
        Vector3 newPosition = transform.position + transform.forward * speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
