using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
	public GameObject player;

	// Move player to the clicked tile and parent them to it.
	public void MovePlayerHere()
	{
		player.transform.SetPositionAndRotation(gameObject.transform.position, gameObject.transform.rotation);
		player.transform.SetParent(transform);
	}
}