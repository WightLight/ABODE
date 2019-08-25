using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class ARController : MonoBehaviour
{
    // List of planes that ARCore detected in the current frame.
    private List<DetectedPlane> detectedPlanes = new List<DetectedPlane>();

    public GameObject GridPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        // Check ARCore session status.
        if(Session.Status != SessionStatus.Tracking)
        {
            return;
        }

        // Fill detectedPlanes list with planes that ARCore detected in the current frame.
        Session.GetTrackables<DetectedPlane>(detectedPlanes, TrackableQueryFilter.New);

        // Instantiate a grid for each DetectedPlane in detectedPlanes.
        for(int i = 0; i < detectedPlanes.Count; i++)
        {
            GameObject grid = Instantiate(GridPrefab, Vector3.zero, Quaternion.identity, transform);

            // Set the position of grid and modify the vertices of the attached mesh
            grid.GetComponent<GridVisualizer>().Initialize(detectedPlanes[i]);
        }
    }
}
