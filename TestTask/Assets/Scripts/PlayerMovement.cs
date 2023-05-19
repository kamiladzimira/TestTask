using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _rotationSpeed = 5f;
    [SerializeField] private Rigidbody _rb;
    private float _movementDirection;
    private float _rotationDirection;
    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 tmpMovementVector = context.ReadValue<Vector2>();
        _movementDirection = tmpMovementVector.y;
        _rotationDirection = tmpMovementVector.x;
    }

    private void Move()
    {
        _rb.MovePosition(_rb.position + (transform.forward * _movementDirection * _moveSpeed * Time.fixedDeltaTime));
    }

    private void Rotate()
    {
        transform.Rotate(transform.up, _rotationDirection * Time.fixedDeltaTime * _rotationSpeed);
    }

    private void FixedUpdate()
    {
        Rotate();
        Move();
    }
}