using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShoot : MonoBehaviour {


public Animator cameraShootAnim;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			cameraShootAnim.SetBool("CameraShoot",true);
		}
		else 
		{
			cameraShootAnim.SetBool("CameraShoot",false);
		}
	
	}
}
