using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody rb;
    Vector3 movement;
    // Update is called once per frame
    void Update()
    {
        // Input
       movement.x = Input.GetAxis("Horizontal");
       movement.z = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position+movement*moveSpeed);

    }
}
