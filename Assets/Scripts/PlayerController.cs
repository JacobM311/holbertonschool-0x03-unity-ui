using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = .000002f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed);
        }
    }
}
