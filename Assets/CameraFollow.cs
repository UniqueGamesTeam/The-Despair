using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


public Transform player;
public Vector3 cameraOffset;
public float smooth = 0.5f;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 newPos = player.position - cameraOffset;
		transform.position = Vector3.Slerp(transform.position,newPos,smooth);
	}
}
