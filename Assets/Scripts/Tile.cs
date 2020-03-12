using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tile : MonoBehaviour
{
	public bool isStartTile;
	public bool isBuilt = false;
	public int mapX;
	public int mapY;
	public bool exitsNorth;
	public bool exitsEast;
	public bool exitsSouth;
	public bool exitsWest;

	public Mini playerMini;
	public TextMeshProUGUI debugText;
	public Tile northExit;
	public Tile eastExit;
	public Tile southExit;
	public Tile westExit;
	public GameObject northButton;
	public GameObject eastButton;
	public GameObject southButton;
	public GameObject westButton;

	void Start()
	{
		// Wow what a bad way to find player mini pls fix.
		playerMini = FindObjectOfType<Mini>();
		if (isStartTile == true)
		{
			isBuilt = true;
			mapX = 0;
			mapY = 0;
			playerMini.gameObject.SetActive(true);
			MoveMiniHere(playerMini);
			ShowBuildableSpaces();
		}
		else CloseBuildMode();
	}

	// Set mini's position to the tapped tile.
	public void MoveMiniHere(Mini mini)
	{
		mini.transform.position = transform.position;
		//player.transform.SetParent(transform);
	}

	public void SetMiniDestination(Mini mini)
	{
		mini.destinationTile = gameObject.GetComponent<Tile>();
	}

	// Display visual for 

	// Display visual for valid adjacent tile placements.
	// May occur when moving to an unexplored space or during an event.
	public void OpenBuildMode()
	{
		ShowBuildableSpaces();
		// Show "Place New Tile Here" UI text. Should say specific
		// tile or area name if a specific tile is required.
		debugText.SetText("Place new tile!");
	}

	public void ShowBuildableSpaces()
	{
		// Disable all of this tile's directional buttons except the ones we can build at.
		if (exitsNorth && northExit == null) { northButton.SetActive(true); } else northButton.SetActive(false);
		if (exitsEast && eastExit == null) { eastButton.SetActive(true); } else eastButton.SetActive(false);
		if (exitsSouth && southExit == null) { southButton.SetActive(true); } else southButton.SetActive(false);
		if (exitsWest && westExit == null) { westButton.SetActive(true); } else westButton.SetActive(false);
	}
	public void CloseBuildMode()
	{
		northButton.SetActive(false);
		eastButton.SetActive(false);
		southButton.SetActive(false);
		westButton.SetActive(false);
		// Erase any "Place New Tile" text.
	}

	public void BuildSelf(Tile fromTile, string direction)
	{
		// Set newly-built tile's mapX and mapY based on the tile it was built from.
		// Adjust exit bools based on rotation of self vs. rotation of start tile.
		// Set newly-built tile's exits to surrounding tiles.
		// Set surrounding tiles' exits that lead here to this tile.
		// Move this tile directly adjacent to its neighbors.
		// Make this tile a child of the Map.
	}
}