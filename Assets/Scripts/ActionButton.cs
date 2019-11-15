using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Abode;

public class ActionButton : MonoBehaviour
{
    public TextMeshProUGUI LabelText;
    public AudioSource Audio;
    public ShootAction Action;

    // Label button based on its action.
    void Start()
    {
        // Hardcoded for now. Should later come from the action or elsewhere.
        LabelText.text = "Shoot";
    }

    // Perform the button's associated action and play SFX.
    // public void DoAction()
    // {
    //     Debug.Log("Do action!");
    //     if(Action.IsApplicable())
    //     {
    //         Action.Act();
    //         Audio.Play();
    //     }
    // }
}
