using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    /**
     * This class moves the player's Camera
     * The camera should be kept as a children of the user character(parent)
     * 
     * Note: Because RotateAroundYaxis is more intuitive with the user
     * character(parent), making a method for the camera wouldn't be much of use.
     */
    public float sensitivity;

    void Update()
    {
        //Move();
    }

    private void Move()
    {
        /**
        * Rotating the camera position.
        * Rotates the camera based on the user's mouse movement
        * Simulating a first person shooter
        */

        float horInput = Input.GetAxis("Mouse X") * sensitivity;
        /**
         * Problem to solve:
         * Having the rotation just in the camera which is
         * inside of the character makes movement awkward.
         * Because the direction of foward is always static,
         * pressing w and moving your mouse wouldn't affect
         * the player movement.
         * The player will have to have a sense of where the
         * character is facing
         * A more intuitive control
         * TODO:
         * Rotate by the y-axis from the character rather than the camera
         */
        float verInput = Input.GetAxis("Mouse Y") * sensitivity;

        Vector3 targRot = transform.rotation.eulerAngles;

        targRot.y += horInput;
        targRot.x -= verInput;

        transform.rotation = Quaternion.Euler(targRot);
    }

    public void RotateAroundXaxis()
    {
        /**
         * Rotates the camera's rotation by the x-axis
         */
        float verInput = Input.GetAxis("Mouse Y") * sensitivity;

        Vector3 targRot = transform.rotation.eulerAngles;
        targRot.x -= verInput;

        transform.rotation = Quaternion.Euler(targRot);
    }
}
