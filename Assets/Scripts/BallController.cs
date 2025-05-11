using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpForce = 5f;
    private Rigidbody rb;
    private bool isGrounded = false;
    private float radius;

    private void Start()
    {
        radius = GetComponent<Renderer>().bounds.extents.magnitude;
        rb = GetComponent<Rigidbody>();
    }

    IEnumerable MyCoroutine()
    {
        yield return new WaitForSecondsRealtime(1);
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, radius + 0.01f, groundLayer))
        {
            Vector3 normal = hit.normal;
            Vector3 direction = (hit.point - transform.position).normalized;
            float dotProduct = Vector3.Dot(normal, -direction);

            if (dotProduct > 0.1f)
            {
                isGrounded = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) & isGrounded == true)
            WantJump();
    }

    private void FixedUpdate()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalDirection, 0.0f, verticalDirection);
        rb.AddForce(movement * speed);
    }

    private void WantJump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
        MyCoroutine();
    }
}

