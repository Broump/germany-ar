using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ExecuteInEditMode runs the script without starting the game
[ExecuteInEditMode]
public class FaceCamera : MonoBehaviour
{   
    //store the position of the camera
    Transform cam;

    //create target angle with (0,0,0)
    Vector3 targetAngel = Vector3.zero;

    void Start() {
        //get the position of the MainCamera
        cam = Camera.main.transform;
    }

    void Update() {
        //the the angel to the camera
        transform.LookAt(cam); 

        //store the angel in targetAngel
        targetAngel = transform.localEulerAngles;
        
        //lock the x and z axis
        targetAngel.x = 0;
        targetAngel.z = 0;

        //transform the angel to the target angel
        transform.localEulerAngles = targetAngel;
    }
}
