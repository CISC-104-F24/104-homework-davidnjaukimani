using System.Collections;
using System.Collections.Generic;
using UnityEngine;



 
public class playerCharacterMovement : MonoBehaviour
{
    //variables
    public bool isDavidCurrentlyEatingABurrito = true;

    public float baseSpeed = 3.0f;
    public float sprintSpeed = 5.0f;

    public Vector3 upwardDirection = new Vector3(0f, 1.0f, 0f);
    public Vector3 actualJump = new Vector3 (0f, 0f, 0f);
    

    private bool onTheGround;

    private float jumpForce;
    private float minJumpForce;
    private float maxJumpForce;

    public Rigidbody playerCharacter;


    // Start is called before the first frame update
    void Start()
    {
        playerCharacter = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

        // SPACE TO JUMP
        //0.2608557

        minJumpForce = 10.0f;
        maxJumpForce = 20.2f;
        bool isJumpKeyDown = false;
        isJumpKeyDown = (Input.GetKey(KeyCode.Space));
        if (isJumpKeyDown == true)
        
        {

         
            if (jumpForce < maxJumpForce)
            {
                jumpForce += minJumpForce * Time.deltaTime;
            }

            actualJump = upwardDirection + (upwardDirection * jumpForce);

            bool isJumpKeyReleased = false;
            isJumpKeyReleased = (Input.GetKeyUp(KeyCode.Space));
            if (isJumpKeyReleased == true)
            {
                playerCharacter.AddForce((actualJump), ForceMode.Impulse);
                jumpForce = 0f;
            }

        }
        else
        {
            bool isJumpKeyReleased = false;
            isJumpKeyReleased = (Input.GetKeyUp(KeyCode.Space));
            if (isJumpKeyReleased == true)
            {
                playerCharacter.AddForce((actualJump), ForceMode.Impulse);
                jumpForce = 0f;
            }

        }
        //HOLD SHIFT TO SPRINT

        bool sprinting = false;
        sprinting = (Input.GetKey(KeyCode.LeftShift));
        //player directional input WASD TO MOVE
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // camera-normalized directional vectors (this took way too long to figure out)
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;
        forward.y = 0;
        right.y = 0;
        forward = forward.normalized;
        right = right.normalized;

        //direction-relative input vectors (took even longer to figure out, my goodness)
        Vector3 forwardRelativeVerticalInput = verticalInput * forward;
        Vector3 rightRelativeVerticalInput = horizontalInput * right;
        float moveStepSprint = sprintSpeed * Time.deltaTime;
        float moveStep = baseSpeed * Time.deltaTime;
        if (sprinting)
        {
            Vector3 cameraRelativeMovement = (forwardRelativeVerticalInput + rightRelativeVerticalInput) * moveStepSprint;
            this.transform.Translate(cameraRelativeMovement, Space.World);
        }
        else
        {
            Vector3 cameraRelativeMovement = (forwardRelativeVerticalInput + rightRelativeVerticalInput) * moveStep;
            this.transform.Translate(cameraRelativeMovement, Space.World);

        }
       
       
        
    }
}
