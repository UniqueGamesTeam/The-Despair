using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlNew : MonoBehaviour {

public float sensitivity = 4f;


	// Use this for initialization

	
	// Update is called once per frame
	void Update () 
	{
		CameraControl();
	}

	void CameraControl()
	{
	float mouseX = Input.GetAxis("Mouse X") * sensitivity*Time.deltaTime;
	float mouseY = Input.GetAxis("Mouse Y") * sensitivity*Time.deltaTime;

	transform.Rotate(-transform.right * mouseY);

	}
}
