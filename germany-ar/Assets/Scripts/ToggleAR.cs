using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ToggleAR : MonoBehaviour {

    public ARPlaneManager planeManager; //references the planeManager
    public ARPointCloudManager pointCloudManager; //references the pointCloudManager

    public void OnValueChanged(bool isOn) { //default: isOn
        VisualizePlanes(isOn);
        VisualizePoints(isOn);
    }

    //activate/deactivate every plane visualizer
    void VisualizePlanes(bool active) {
        planeManager.enabled = active;
        foreach (ARPlane plane in planeManager.trackables) {
            plane.gameObject.SetActive(active);
        }
    }

    //activate/deactivate every pointcloud
    void VisualizePoints(bool active) {
        pointCloudManager.enabled = active;
        foreach (ARPointCloud pointCLoud in pointCloudManager.trackables) {
            pointCLoud.gameObject.SetActive(active);
        }
    }
}