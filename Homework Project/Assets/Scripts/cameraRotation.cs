using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    //Variables
    // rotation 
    public float sensitivityX = 2.0f;
    public float sensitivityY = 2.0f;
    public float rotationLimit = 0.0f;
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse position
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");


        //rotate camera with mouse movement
        rotationX += mouseX * sensitivityX;
        rotationY -= mouseY * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, -rotationLimit, rotationLimit);
        transform.rotation = Quaternion.Euler(rotationY, rotationX, 0);
        playerBody.rotation = Quaternion.Euler(rotationY, rotationX, 0);
    }
}