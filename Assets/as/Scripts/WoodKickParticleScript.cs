using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodKickParticleScript : MonoBehaviour {

public GameObject woodParticle;
public GameObject myCamera;


RaycastHit hitBox;
	// Update is called once per frame
	void Update () 
	{
		WoodImpactParticle();
		//Debug.DrawRay(myCamera.transform.position, myCamera.transform.forward * 2.3f);
	}

	void WoodImpactParticle()
	{
		if(Physics.Raycast(myCamera.transform.position, myCamera.transform.forward,out hitBox,2.3f) && hitBox.transform.tag == "Box")
  	{
  		Instantiate(woodParticle,hitBox.point,Quaternion.FromToRotation(myCamera.transform.forward,hitBox.normal));
  	}	
	}
}
