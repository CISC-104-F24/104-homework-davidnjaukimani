using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Variables

    //speed
    public float baseSpeed = 10.0f;
    public float jumpSpeed = 10f;

    // direction
    public Vector3 forwardDirection = new Vector3(0f, 0f, 1f);
    public Vector3 backDirection = new Vector3(0f, 0f, -1f);
    public Vector3 leftDirection = new Vector3(-1f, 0f, 0f);
    public Vector3 rightDirection = new Vector3(1f, 0f, 0f);
    public Vector3 upwardDirection = new Vector3(0f, 1000f, 0f);
    public float distanceTraveled = 0f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      

        // directional movement
        //forward
        bool isForward = false;
        isForward = (Input.GetKey(KeyCode.W));
        if ( isForward == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + forwardDirection.normalized * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }

        //backwards
        bool isBack = false;
        isBack = (Input.GetKey(KeyCode.S));
        if (isBack == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + backDirection.normalized * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }

        //left
        bool isLeft = false;
        isLeft = (Input.GetKey(KeyCode.A));
        if (isLeft == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + leftDirection.normalized * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }

        //right
        bool isRight = false;
        isRight = (Input.GetKey(KeyCode.D));
        if (isRight == true)
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + rightDirection.normalized * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }
        bool isUp = false;


    //jump
        isUp = (Input.GetKeyDown(KeyCode.Space));
        if (isUp == true)
        {
            float jumpStep = jumpSpeed * Time.deltaTime;
            transform.position = transform.position + upwardDirection;

            distanceTraveled = distanceTraveled + jumpStep;
        }
    } 
}
