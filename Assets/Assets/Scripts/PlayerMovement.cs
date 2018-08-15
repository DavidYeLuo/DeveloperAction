using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float distMultiplier;

    private Camera cam;
    private CameraMovement camMovement;
    private Rigidbody rb;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cam = GetComponentInChildren<Camera>();
        camMovement = cam.GetComponent<CameraMovement>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        camMovement.RotateAroundXaxis();
        RotateAroundYaxis();
    }

    void FixedUpdate ()
    {
        KeyPress();
        Move();
	}


    private void Move()
    {
    /**
     * Moves the character from user inputs
     * Note: Rotation plays a role on telling where foward is
     */ 
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");

        /*
         * TODO: Use forces for movements instead of changing directly from transform.
         */
        /* Trying to replace
        * Vector3 changeIndistance = new Vector3(deltaX, 0, deltaY);
        *
        * transform.Translate(changeIndistance);
        */

        //rb.AddForce(horInput * distMultiplier, 0, verInput * distMultiplier, ForceMode.Force);
        rb.AddForce(transform.forward * verInput * distMultiplier, ForceMode.Impulse);
        rb.AddForce(transform.right * horInput * distMultiplier, ForceMode.Impulse);
    }


    private void KeyPress()
    {
        /** Key presses are handled here **/

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            // Unlocks the cursors from 1st person
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        // TODO: Add a GetKeyedDown(left_click) to regain the focus after 'esc'
        // 
    }

    public void RotateAroundYaxis()
    {
        /**
         * Rotates the player rotation by the y-axis
         */
        float horInput = Input.GetAxis("Mouse X") * cam.GetComponent<CameraMovement>().sensitivity;

        Vector3 targRot = transform.rotation.eulerAngles;
        targRot.y += horInput;

        transform.rotation = Quaternion.Euler(targRot);
    }

}
