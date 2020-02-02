using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horsePower = 0;
    [SerializeField] float turnSpeed = 45.0f;
    [SerializeField] GameObject centerOfMass;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    public void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);

        // Move the vehicle forward based on vertical input.
        // transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * verticalInput);

        // Rotate the vehicle based on horizontal input.
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
