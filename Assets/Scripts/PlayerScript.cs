using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    float movingSpeed = 10f;
    float maxSpeed = 1f;
    Rigidbody rb;

    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        // time and life only move forward
        moveVertical = moveVertical > 0 ? moveVertical : 0;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        /**
        if (!Input.GetMouseButton(0))
        {
            rb.AddForce(movement * movingSpeed, ForceMode.VelocityChange);
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);

            // Get the mouse delta. This is not in the range -1...1
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            //float v = verticalSpeed * Input.GetAxis("Mouse Y");

            transform.Rotate(0, h, 0);
        }
    */
    }
}
