using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using TMPro;
public class ImageRecognitionExample : MonoBehaviour
{
    private ARTrackedImageManager ARTrackedImageManager;
    public TextMeshProUGUI DebugText;
    public GameObject characterCardObject;
    public GameObject eventCardObject;

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
                Instantiate(eventCardObject, trackedImage.transform);
            }
            else if(trackedImage.referenceImage.name == "Sizzle Lizard")
            {
                Instantiate(characterCardObject, trackedImage.transform);
            }
            trackedImage.transform.localScale = new Vector3(0.88f, 0.88f, 0.88f);
            DebugText.SetText("Found " + trackedImage.referenceImage.name + ".");
        }
    }
}