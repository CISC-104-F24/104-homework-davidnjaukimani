using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Variables

    //speed
    public float baseSpeed = 2.0f;
    public float jumpSpeed = 10f;
    public float sprintSpeed = 4.0f;
    // direction
    public Vector3 forwardDirection = new Vector3(0f, 0f, -1f);
    public Vector3 backDirection = new Vector3(0f, 0f, 1f);
    public Vector3 leftDirection = new Vector3(0f, -1f, 0f);
    public Vector3 rightDirection = new Vector3(0f, 1f, 0f);
    public Vector3 upwardDirection = new Vector3(0f, 1f, 0f);
    public float distanceTraveled = 0f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        // directional movement
        //up right 
       
       
        
        // up left
        //back right
        //back left

        //forward
        bool isForward = false;
        isForward = (Input.GetKeyDown(KeyCode.W));
        if (isForward == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + forwardDirection * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }

        //backwards
        bool isBack = false;
        isBack = (Input.GetKey(KeyCode.S));
        if (isBack == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + backDirection * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }

        //left
        bool isLeft = false;
        isLeft = (Input.GetKey(KeyCode.A));
        if (isLeft == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + leftDirection * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }

        //right

        bool isRight = false;
        isRight = (Input.GetKey(KeyCode.D));
        if (isRight == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + rightDirection * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }



        //jump
        bool isUp = false;
        isUp = (Input.GetKeyDown(KeyCode.Space));
        if (isUp == true)
        {
            float jumpStep = jumpSpeed * Time.deltaTime;
            transform.position = transform.position + upwardDirection;

            distanceTraveled = distanceTraveled + jumpStep;
        }

        //SPRINTING
        bool sprinting = false;

        sprinting = (Input.GetKey(KeyCode.LeftShift));
        if (sprinting == true)
        {
            baseSpeed = (sprintSpeed);
        }

    }
}