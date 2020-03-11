using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using TMPro;
public class ABODEImageRecognition : MonoBehaviour
{
    private ARTrackedImageManager ARTrackedImageManager;
    public TextMeshProUGUI DebugText;
    public GameObject characterCardObject;
    public GameObject eventCardObject;
    public GameObject curveTile;
    public GameObject forkTile;

    private void Awake()
    {
        ARTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        ARTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }
    
    public void OnDisable()
    {
        ARTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            if(trackedImage.referenceImage.name == "Murder in Leilef Wood")
            {
                //Instantiate(eventCardObject, trackedImage.transform);
                Instantiate(characterCardObject, trackedImage.transform);
            }
            else if (trackedImage.referenceImage.name == "Sizzle Lizard")
            {
                Instantiate(characterCardObject, trackedImage.transform);
                trackedImage.transform.localScale = new Vector3(0.88f, 0.88f, 0.88f);
            }
            else if (trackedImage.referenceImage.name == "Curve Tile")
            {
                Instantiate(curveTile, trackedImage.transform);
                //trackedImage.transform.localScale = new Vector3(0.88f, 0.88f, 0.88f);
                curveTile.GetComponent<Tile>().ShowBuildableSpaces();
            }
            else if (trackedImage.referenceImage.name == "Fork Tile")
            {
                Instantiate(forkTile, trackedImage.transform);
            }
            DebugText.SetText("Found " + trackedImage.referenceImage.name + ".");
        }
    }
}