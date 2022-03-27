using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Gaze : MonoBehaviour
{
    List<InfoBehavior> infos = new List<InfoBehavior>(); //create a list for all InfoBehaviors

    void Update()
    {

        //find all InfoBehaviors and add them to the list
        infos = FindObjectsOfType<InfoBehavior>().ToList();

        //if the camera hits an gameobject with the tag "hasInfo" it will open the sectionInfo of the specific gameobject
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasInfo"))
            {
                OpenInfo(go.GetComponent<InfoBehavior>());
            }
        }
        else
        {
            CloseAll();
        }
    }

    //opening all sectionInfos
    void OpenInfo(InfoBehavior desiredInfo)
    {
        foreach (InfoBehavior info in infos)
        {
            if (info == desiredInfo)
            {
                info.OpenInfo();
            }
            else
            {
                info.CloseInfo();
            }
        }
    }

    //close all sectionInfos
    void CloseAll()
    {
        foreach (InfoBehavior info in infos)
        {
            info.CloseInfo();
        }
    }
}
