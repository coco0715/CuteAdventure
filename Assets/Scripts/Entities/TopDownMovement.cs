using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movementDiraction = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDiraction);
    }

    private void Move(Vector2 diraction)
    {
        _movementDiraction = diraction;
    }

    private void ApplyMovement(Vector2 diraction)
    {
        diraction = diraction * 5;
        _rigidbody.velocity = diraction;
    }
}
