using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDirectionalButton : MonoBehaviour
{
    public Tile tile;
    public string direction;

    public void BuildTileHere(Tile tileToBuild)
    {
        // if there's an unbuilt tile near my position and a good enough rotation,
        // Tell it to BuildSelf(tile, direction).
    }
}
