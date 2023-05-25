using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GridBrushBase;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _rotationSpeed = 5f;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] Camera _camera;
    private Vector2 _inputMovementDirection;
    private Vector3 _movementDirection;
    private float _rotationDirection;
    public void OnMove(InputAction.CallbackContext context)
    {
        _inputMovementDirection = context.ReadValue<Vector2>();
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        _rotationDirection = context.ReadValue<float>();
    }

    private void Rotate()
    {
       transform.Rotate(Vector2.up * Time.deltaTime * _rotationSpeed * _rotationDirection);

    }
    private void Move()
    {
        _movementDirection = ((transform.forward * _inputMovementDirection.y) + (transform.right * _inputMovementDirection.x)).normalized;
        _rb.MovePosition(_rb.position + (_movementDirection * _moveSpeed * Time.fixedDeltaTime));
    }

    private void Update()
    {
        Rotate();
    }

    private void FixedUpdate()
    {
        Move();
    }
}