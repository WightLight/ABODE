using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCard : MonoBehaviour
{
	public PlayerCharacter player;
	public Image itemImage;
	public Image textPanel;
	public AudioSource itemAudio;
	public AudioClip gunShotSFX;
	public AudioClip casingSFX;
	public AudioClip triggerClickSFX;
	public AudioClip reloadSFX;
	public AudioClip drinkSFX;

	public int charges;
	public int maxCharges;

	public TMP_Text title;
	public TMP_Text cardText;
	public int dialogueID = 0;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		cardText.text = "Charges: " + charges + "/" + maxCharges;
	}

	public void OpenCard()
	{
		if(title != null)
		{
			title.gameObject.SetActive(false);
		}

		if(dialogueID == 1)
		{
			itemImage.gameObject.SetActive(true);
			textPanel.gameObject.SetActive(true);

			dialogueID = 2;
			return;
		}
	}

	public void SideshowShoot(CharacterCard target)
	{
		target.characterAudio.PlayOneShot(triggerClickSFX);

		// If we're loaded, make shootbang happen.
		if(charges >= 1 && player.AP >= 3)
		{
			player.AP -= 3;
			charges -= 1;
			target.HP -= 2;
			target.characterAudio.PlayOneShot(gunShotSFX);
			target.characterAudio.PlayOneShot(casingSFX);
		}
	}

	public void SideshowReload()
	{
		// If charges aren't full and we have enough AP, recharge.
		if(charges < maxCharges && player.AP >= 4)
		{
			player.AP -= 4;
			itemAudio.PlayOneShot(reloadSFX);
			charges = maxCharges;
		}
	}

	public void FlaskDrink()
	{
		// If we have a charge and enough AP, take a drink.
		// You don't wanna know what's in here...
		// But I'll tell you one thing: It's chewy!
		if(charges >= 1 && player.AP >= 4)
		{
			player.AP -= 4;
			player.HP += 4;
			itemAudio.PlayOneShot(drinkSFX);
			charges -= 1;
		}
	}
}
