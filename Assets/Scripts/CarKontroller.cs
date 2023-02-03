using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarKontroller : MonoBehaviour
{

    [SerializeField] private new Rigidbody2D rigidbody2D;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;

    private float _input;


    private void Update()
    {
        _input = Input.GetAxis("Horizontal");
    }


    private void FixedUpdate()
    {
        rigidbody2D.velocity = transform.up * (moveSpeed * Time.deltaTime);
        rigidbody2D.angularVelocity = -_input * (rotateSpeed * Time.deltaTime);
    }
}
