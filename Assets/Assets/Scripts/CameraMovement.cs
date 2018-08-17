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
