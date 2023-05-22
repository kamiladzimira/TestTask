using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private int _rotationSpeed;
    [SerializeField] private int _damage;
    [SerializeField] private float _followTime = 2;
    [SerializeField] private float _lifeTime = 6;
    private float _timer = 0;
    private Vector3 _direction;

    public int Damage => _damage;

    private void Update()
    {
        _timer += Time.deltaTime;
        ChangeRotation();
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


    private void ChangeRotation()
    {
        Quaternion rotationTarget = Quaternion.LookRotation(Vector3.back, _direction);
        Quaternion newRotation = Quaternion.RotateTowards(transform.rotation, rotationTarget, _rotationSpeed * Time.deltaTime);
        transform.rotation = newRotation;
    }
}
