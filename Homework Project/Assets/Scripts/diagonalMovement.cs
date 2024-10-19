using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diagonalMovement : MonoBehaviour
{
    // Variables

    //speed
    public float baseSpeed = 2.0f;
    public float jumpSpeed = 10f;
    public float sprintSpeed = 4.0f;
    // direction
    public Vector3 forwardDirection = new Vector3(0f, 0f, -1f);
    public Vector3 backDirection = new Vector3(0f, 0f, 1f);
    public Vector3 leftDirection = new Vector3(-1f, 0f, 0f);
    public Vector3 rightDirection = new Vector3(1f, 0f, 0f);
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
        bool isForward = false;
        isForward = (Input.GetKey(KeyCode.W));
        bool isRight = false;
        isRight = (Input.GetKey(KeyCode.D));
        if (isForward && isRight == true) ;
        {
            float moveStep = baseSpeed * Time.deltaTime;
            transform.position = transform.position + forwardDirection.normalized * moveStep;

            distanceTraveled = distanceTraveled + moveStep;
        }
        // up left
       
       





    }
}