using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotation : MonoBehaviour
{
    public float sensitivityX = 2.0f;
    public float sensitivityY = 2.0f;
    public float rotationLimit = 80.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    public Transform playerBody;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotationX += mouseX * sensitivityX;
        rotationY -= mouseY * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, -rotationLimit, rotationLimit);

        playerBody.rotation = Quaternion.Euler(rotationY, rotationX, 0);
        transform.localRotation = Quaternion.Euler(rotationY, rotationX, 0);
    }
}
