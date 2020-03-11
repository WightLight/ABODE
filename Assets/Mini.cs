using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini : MonoBehaviour
{
    public Tile destinationTile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LerpToTile();
    }

    // Lerp mini to destination tile.
    public void LerpToTile()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, destinationTile.transform.position.x, 0.1f), Mathf.Lerp(transform.position.y, destinationTile.transform.position.y, 0.1f), Mathf.Lerp(transform.position.z, destinationTile.transform.position.z, 0.1f));
        //Mathf.Lerp(mini.transform.position.y, transform.position.y, 0.5f);
        //Mathf.Lerp(mini.transform.position.z, transform.position.z, 0.5f);
    }
}
