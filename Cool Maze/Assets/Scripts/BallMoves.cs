using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoves : MonoBehaviour
{
    private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    private float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector3(horizontalInput, 0.0f, verticalInput) * speed);
    }
}
