using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

public GameObject zombie;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt(Vector3.forward);
	}
	
	

}
