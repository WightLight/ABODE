using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventCard : MonoBehaviour
{
	public Image title;
	public Image character;
	public Image textPanel;
	
	public TMP_Text cardText;
	public int dialogueID;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void OpenCard()
	{
		if(title != null)
		{
			title.gameObject.SetActive(false);
		}

		if(dialogueID == 0)
		{
			character.gameObject.SetActive(true);
			textPanel.gameObject.SetActive(true);

			cardText.text = "Magpie: Hey, what's up? My name's <#ff9966>Magpie</color>, and I'm a big huge goofass.";
			dialogueID = 1;
			return;
		}
		if(dialogueID == 1)
		{
			cardText.text = "Magpie: I provide my ranger skills as a member of the <#ff9966>Corporium Regiment</color>...";
			dialogueID = 2;
			return;
		}
		if(dialogueID == 2)
		{
			cardText.text = "Magpie: But most of my time is spent being a major pain in <#ff9966>Barnaby's ass</color>.";
			dialogueID = 3;
			return;
		}
		if(dialogueID == 3)
		{
			cardText.text = "Magpie: The truth is he's one of my bestest friends and I'm just scared of my own emotions.";
			dialogueID = 4;
			return;
		}
		if(dialogueID == 4)
		{
			character.gameObject.SetActive(false);
			textPanel.gameObject.SetActive(false);
			dialogueID = 0;

			cardText.text = "";
			return;
		}
	}
}
