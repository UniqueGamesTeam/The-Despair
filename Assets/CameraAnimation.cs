using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour {

	public GameObject camera;
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.LeftShift))
		{
			camera.transform.Rotate(0,0,10);
		}
		


	}
}
