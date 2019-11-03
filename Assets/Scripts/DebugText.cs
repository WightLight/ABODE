using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using GoogleARCore;

public class DebugText : MonoBehaviour
{
    public TextMeshProUGUI BottomText;
    public ARCoreSessionConfig SessionConfig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BottomText.text = SessionConfig.CameraFocusMode.ToString();
    }
}
