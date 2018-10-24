using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShotScript : MonoBehaviour {
public Animator GunShotAnim;
public Animator HandsShot;


public Camera myCamera;
public ParticleSystem flash;
	// Use this for initialization
	
public GameObject bulletDecal;

public bool canShoot = false;
public ShotAllow shootFlag;
public Animator cameraShootAnim;

//

	// Update is called once per frame
	void Update () 
	{
		
		if (this.HandsShot.GetCurrentAnimatorStateInfo(0).IsName("GunPickAnim"))
 		{
   	 HandsShot.SetBool("Picked",true);
 		}

		if(Input.GetMouseButtonDown(0))
		{ 
			Shoot();
			Shooting();
		}
		if(Input.GetMouseButtonUp(0))
		{
			UnShoot();
		}
	}

	void Shoot()
	{
		
		if(shootFlag.shoot == true)
		{
			GunShotAnim.SetBool("Shoot",true);	
			HandsShot.SetBool("ShootHands",true);
			HandsShot.SetBool("ShotWhileRun",true);
			cameraShootAnim.SetBool("CameraShoot",true);
		}
	}

	void UnShoot()
	{
		GunShotAnim.SetBool("Shoot",false);	
		HandsShot.SetBool("ShootHands",false);
		HandsShot.SetBool("ShotWhileRun",false);
		cameraShootAnim.SetBool("CameraShoot",false);
	}

  void Shooting()
  {
  	RaycastHit hit;
  	
  	if(shootFlag.shoot == true && Physics.Raycast(myCamera.transform.position, myCamera.transform.forward,out hit))
  	{
  		Instantiate(bulletDecal,hit.point,Quaternion.FromToRotation(Vector3.up,hit.normal));
  		//Debug.Log(hit.transform.name);
  	}	
  }
	public void ShootFlash()
	{
		if(shootFlag.shoot == true)
		{
			flash.Play();
		}
	}

}
