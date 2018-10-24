﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHp : MonoBehaviour {

//public GameObject Box;
public GameObject CrackedBox;


public float Health;
	
	
	void Start () 
	{
		this.Health = 60f;
	}

	void Update()
	{
		if(this.Health<=0)
			{
				Instantiate(CrackedBox,transform.position,transform.rotation);
				Destroy(this.gameObject);
			}
		//Debug.Log(Health);
	}
	void BoxHealth(float weaponDamage)
	{
		Health -= weaponDamage;
	}

	public void OnTriggerEnter(Collider box)
	{
	
	if(box.gameObject.tag == "AttackHand")
		{
			Debug.Log("KICKEEEED");
			this.Health-=20f;
			
		}
	}
	// Update is called once per frame

}
