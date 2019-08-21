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

			cardText.text = "Magpie: Hey there. You're <#ff9966>Bailey</color>, right?";
			dialogueID = 1;
			return;
		}
		if(dialogueID == 1)
		{
			cardText.text = "Magpie: Sorry that goofus <#ff9966>Brendan</color> took a while to reply...";
			dialogueID = 2;
			return;
		}
		if(dialogueID == 2)
		{
			cardText.text = "Magpie: He's been up to his ears in projects like this one!";
			dialogueID = 3;
			return;
		}
		if(dialogueID == 3)
		{
			cardText.text = "Magpie: Guy's gotta learn to take a break and socialize once in a while.";
			dialogueID = 4;
			return;
		}
		if(dialogueID == 4)
		{
			character.gameObject.SetActive(false);
			textPanel.gameObject.SetActive(false);

			cardText.text = "";
			return;
		}
	}
}
