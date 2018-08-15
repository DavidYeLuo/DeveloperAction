using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float distMultiplier;

    private Camera cam;
    private CameraMovement camMovement;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cam = GetComponentInChildren<Camera>();
        camMovement = cam.GetComponent<CameraMovement>();
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
        float deltaX = Input.GetAxis("Horizontal") * distMultiplier;
        float deltaY = Input.GetAxis("Vertical") * distMultiplier;

        /*
         * TODO: Use forces for movements instead of changing directly from transform.
         */ 
        Vector3 changeIndistance = new Vector3(deltaX, 0, deltaY);

        transform.Translate(changeIndistance);
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
