using System.Collections;
using System.Collections.Generic;
using UnityEngine;



 
public class playerCharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player input
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

        // camera-relative movement (the sands of time shifted in the amount of time it took me to figure this out)
        float baseSpeed = 3.0f;
        float moveStep = baseSpeed * Time.deltaTime;
        Vector3 cameraRelativeMovement = (forwardRelativeVerticalInput + rightRelativeVerticalInput) * moveStep;
        this.transform.Translate (cameraRelativeMovement, Space.World);

        
    }
}
