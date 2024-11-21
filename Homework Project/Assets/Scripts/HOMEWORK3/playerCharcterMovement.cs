using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 3.0f;
    public float sprintSpeed = 5.0f;

    private Rigidbody playerRigidbody;

    private bool isSprinting;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        if (playerRigidbody != null)
        {
            playerRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }

    void Update()
    {
        //sprint forward only WITH SHIFT
        isSprinting = Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W);
    }

    void FixedUpdate()
    {
        // MOVE WITH WASD
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if (Input.GetKey(KeyCode.W)) verticalInput = 1f;
        if (Input.GetKey(KeyCode.S)) verticalInput = -1f;
        if (Input.GetKey(KeyCode.A)) horizontalInput = -1f;
        if (Input.GetKey(KeyCode.D)) horizontalInput = 1f;

        // Get camera orientation
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        // Ensure movement is only on the XZ plane
        forward.y = 0f;
        right.y = 0f;

        // Normalize directional vectors
        forward = forward.normalized;
        right = right.normalized;

        // Calculate movement direction relative to the camera
        Vector3 movement = (forward * verticalInput + right * horizontalInput).normalized;

        // Determine movement speed
        float currentSpeed = isSprinting ? sprintSpeed : walkSpeed;

        // Apply movement
        playerRigidbody.MovePosition(transform.position + movement * currentSpeed * Time.fixedDeltaTime);
    }
}
