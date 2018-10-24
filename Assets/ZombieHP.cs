using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHP : MonoBehaviour {

	// Use this for initialization
	public float zombieHealth;

	

	void Start () 
	{
		this.zombieHealth = 60f;
	}

	void Update()
	{
		if(this.zombieHealth<=0)
			{
				//Set Animatior
				Debug.Log("ZombieDead");
			}
		//Debug.Log(zombieHealth);
	}
	void ZombieHealth(float weaponDamage)
	{
		zombieHealth -= weaponDamage;
	}


}