using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardMovement : MonoBehaviour
{
    Rigidbody rb;
    float horizontal = 0;
    Vector3 vec;
    public float minX;
    public float maxX;

    public float characterSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vec = new Vector3(horizontal, 0);

        rb.velocity = vec * characterSpeed;

        rb.position = new Vector3(Mathf.Clamp(rb.position.x, minX, maxX), 0.0f, 0.0f);
    }
}
