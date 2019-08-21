using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerCharacter : MonoBehaviour
{
	public TMP_Text HPText;
	public TMP_Text APText;
	public CharacterCard enemy;

	public int HP = 10;
	public int AP = 10;
	public int maxHP = 10;
	public int maxAP = 10;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Update player's HP & AP UI texts.
		// White = Full HP. Yellow = Less HP. Red = Low HP. Blue = More HP.*
		if(HP == maxHP)
		{
			HPText.text = "<#ffffff>HP: " + HP;
		}
		else if(HP < maxHP && HP > 2)
		{
			HPText.text = "<#ffff44>HP: " + HP;
		}
		else if(HP <= 2)
		{
			HPText.text = "<#ff4444>HP: " + HP;
		}
		else if(HP > maxHP)
		{
			HPText.text = "<#4444ff>HP: " + HP;
		}

		// White = Full AP. Yellow = Less AP. Red = Low AP. Blue = More AP.
		if(AP == maxAP)
		{
			APText.text = "<#ffffff>AP: " + AP;
		}
		else if(AP < maxAP && AP > 2)
		{
			APText.text = "<#ffff44>AP: " + AP;
		}
		else if(AP <= 2)
		{
			APText.text = "<#ff4444>AP: " + AP;
		}
		else if(AP > maxAP)
		{
			APText.text = "<#4444ff>AP: " + AP;
		}

		// On death, game over!
		if(HP <= 0)
		{
			SceneManager.LoadScene("Start Screen");
		}
	}

	// End player's turn to let other characters move. Then refill player AP.
	public void EndPlayerTurn()
	{
		enemy.Spit();
		AP = maxAP;
	}
}
