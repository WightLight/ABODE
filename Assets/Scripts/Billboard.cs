using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
	public Camera ARCamera;
	
	// Face toward the camera at all times.
	void Update ()
	{
		Vector3 v = ARCamera.transform.position - transform.position;
		v.x = v.z = 0.0f;
		transform.LookAt(ARCamera.transform.position - v);
		transform.Rotate(0,180,0);
	}
}
