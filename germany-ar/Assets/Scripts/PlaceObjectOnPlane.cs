using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceObjectOnPlane : MonoBehaviour
{
    private ARRaycastManager raycastManager; //the raycastmanager scans the enviorment
    private Pose placementPose; //Pose contains information of Position and Rotation
    private bool placementPoseIsValid; //contains whether the placement position is valid or not
    private bool isObjectPlaced; //contains whether the object is placed or not

    public GameObject positionIndicator; //contains the position indicator
    public GameObject prefabToPlace; //contains the prefab which you want to place
    public Camera ARCamera; //contains the AR Camera

    private void Awake(){
        raycastManager = GetComponent<ARRaycastManager>(); //gets the ARRaycastManager from the AR Session Origin
    }

    
    void Update()
    {   
        //checks if an Object is already placed
        if (!isObjectPlaced) {

            //gets the updated placement position
            UpdatePlacementPose();
            
            //checks if the placement postion is valid + if there is a touch on the display + checks if the touch was holding
            if(placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
                
                //places the object
                PlaceObject();

            }
        }
        
    }

    private void UpdatePlacementPose() {

        //gets the middle of the screen
        var screenCenter = ARCamera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        //contains the hits of the ARRaycastmanager (checks for planes where you can place the object)
        var hits = new List<ARRaycastHit>();

        //to track the whole plane
        raycastManager.Raycast(screenCenter, hits, TrackableType.All);

        //check if the placmeent pose is valid
        placementPoseIsValid = hits.Count > 0;

        if (placementPoseIsValid){

            //get the most recent hit position
            placementPose = hits[0].pose;

            //when the camere is moved forward it will be stored in the variable
            var cameraForward = ARCamera.transform.forward;

            //calculate the new camera position (normalized maked the y axies a 90° angle)
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;

            //change the rotation pose
            placementPose.rotation = Quaternion.LookRotation(cameraBearing);

            //activate the position indicator 
            positionIndicator.SetActive(true);

            //place the position indicator where the camera moved
            positionIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else {
            //disable the position indicator
            positionIndicator.SetActive(false);
        }
    }

    private void PlaceObject() {

        //spawn the prefab onto the placement position
        Instantiate(prefabToPlace, placementPose.position, placementPose.rotation);

        //set isObjectPlaced true
        isObjectPlaced = true;

        //deactivate the position indicator
        positionIndicator.SetActive(false);
    }
}
