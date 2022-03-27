using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBehavior : MonoBehaviour
{   

    [SerializeField]
    Transform SectionInfo; //get the transform values of the sectionInfo

    const float Speed = 6f; //speed for opening the sectionInfo

    Vector3 desiredScale = Vector3.zero; //desiredscale value is (0,0,0)

    void Update()
    {   
        //transform the sectionInfo scale to the desiredsacle in given time
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, desiredScale, Time.deltaTime * Speed);
    }

    public void OpenInfo() {
        //when opening the sectionInfo the Vector is (1,1,1)
        desiredScale = Vector3.one;
    }

    public void CloseInfo() {
        //when closing the sectionInfo the Vector is (0,0,0)
        desiredScale = Vector3.zero;
    }

}
