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
    [SerializeField] Transform _camera;
    private Vector2 _inputMovementDirection;
    private Vector3 _movementDirection;
    private Vector2 _rotationDirection;
    private float _rotationRange = 0.7f;
    public void OnMove(InputAction.CallbackContext context)
    {
        _inputMovementDirection = context.ReadValue<Vector2>();
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        _rotationDirection = context.ReadValue<Vector2>();
    }

    private void PlayerRotate()
    {
        transform.Rotate(Vector2.up * Time.deltaTime * _rotationSpeed * _rotationDirection.x);
    }
    private void CameraRotate()
    {
        Quaternion oldRotation = _camera.rotation;
        _camera.Rotate(Vector2.left * Time.deltaTime * _rotationSpeed * _rotationDirection.y);
        if (Vector3.Dot(_camera.forward, transform.forward) < _rotationRange)
        {
            _camera.rotation = oldRotation;
        }
    }
    private void Move()
    {
        _movementDirection = ((transform.forward * _inputMovementDirection.y) + (transform.right * _inputMovementDirection.x)).normalized;
        _rb.MovePosition(_rb.position + (_movementDirection * _moveSpeed * Time.fixedDeltaTime));
    }

    private void Update()
    {
        PlayerRotate();
        CameraRotate();
    }

    private void FixedUpdate()
    {
        Move();
    }
}