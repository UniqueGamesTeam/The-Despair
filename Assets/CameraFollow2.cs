using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour {

public Vector3 myPos;
public Transform player;
	// Use this for initialization
	void Start () {
		transform.position = player.position + myPos;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = player.position + myPos;
	}
}
