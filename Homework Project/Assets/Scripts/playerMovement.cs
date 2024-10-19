using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Variables

    //speed
    public float baseSpeed = 3.0f;
    public float jumpSpeed = 10f;
    public float sprintSpeed = 5.0f;
    // direction
    public Vector3 forwardDirection = new Vector3(0f, 0f, 1.0f);
    public Vector3 backDirection = new Vector3(0f, 0f, -1.0f);
    public Vector3 leftDirection = new Vector3(-1.0f, 0f, 0f);
    public Vector3 rightDirection = new Vector3(1.0f, 0f, 0f);
    public Vector3 upwardDirection = new Vector3(0f, 1.0f, 0f);
    public float distanceTraveled = 0f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        bool sprinting = false;
        bool isUp = false;
        bool isRight = false;
        bool isLeft = false;
        bool isBack = false;
        bool isForward = false;
        //forward

        isForward = (Input.GetKey(KeyCode.W));
        if (isForward == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + forwardDirection * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }

        //left


        isLeft= (Input.GetKey(KeyCode.A));
        if (isLeft == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + leftDirection * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }


        //right

        isRight = (Input.GetKey(KeyCode.D));
        if (isRight == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + rightDirection * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }

        //backwards


        isBack = (Input.GetKey(KeyCode.S));
        if (isBack == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + backDirection * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }


        //jump

        isUp = (Input.GetKeyDown(KeyCode.Space));
        if (isUp == true)
        {
            float jumpStep = jumpSpeed * Time.deltaTime;
            transform.position = transform.position + upwardDirection;

            distanceTraveled = distanceTraveled + jumpStep;
        }

        //SPRINTING


        sprinting = (Input.GetKey(KeyCode.LeftShift));
        if (sprinting)
        {
            baseSpeed = sprintSpeed;
        }
        else
        {
            baseSpeed = 2.0f; 

        }
    }

}
