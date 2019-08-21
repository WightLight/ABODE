using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CharacterCard : MonoBehaviour
{
	public PlayerCharacter player;
	public Image characterImage;
	public Image textPanel;
	public AudioSource characterAudio;
	public AudioClip acidSpitSFX;

	public int HP = 12;
	public int AP = 10;
	public int maxHP = 12;
	public int maxAP = 10;

	public TMP_Text title;
	public TMP_Text HPText;
	public TMP_Text cardText;
	public int dialogueID = 0;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		// White = Full HP. Yellow = Less HP. Red = Low HP.
		if(HP == maxHP)
		{
			HPText.text = "<#ffffff>" + HP + "HP";
		}
		else if(HP < maxHP && HP > 2)
		{
			HPText.text = "<#ffff44>" + HP + "HP";
		}
		else if(HP <= 2)
		{
			HPText.text = "<#ff4444>" + HP + "HP";
		}

		// If characterImage dies, restart the scene.
		if(HP <= 0)
		{
			SceneManager.LoadScene("Start Screen");
		}
	}

	public void OpenCard()
	{
		if(title != null)
		{
			title.gameObject.SetActive(false);
		}

		if(dialogueID == 1)
		{
			characterImage.gameObject.SetActive(true);
			textPanel.gameObject.SetActive(true);

			cardText.text = "The creature spits a glowing glob of acid!\n-3 HP";
			player.HP -= 3;

			dialogueID = 2;
			return;
		}
	}

	public void Spit()
	{
		characterAudio.PlayOneShot(acidSpitSFX);
		cardText.text = "The creature spits a glowing glob of acid!\n-3 HP";
		player.HP -= 3;
	}
}
