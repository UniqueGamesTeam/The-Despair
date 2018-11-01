using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHP : MonoBehaviour {

	// Use this for initialization
	public float zombieHealth;
    public GameObject Zombie;
    public save_script save;

    void Start () 
	{
		this.zombieHealth = 60f;
	}

	void Update()
	{
		if(this.zombieHealth<=0)
			{
            //Set Animatior
            Zombie.SetActive(false);
            Debug.Log(Zombie.name);

            save.DeadZombies(Zombie.name);
        }
		//Debug.Log(zombieHealth);
	}
	void ZombieHealth(float weaponDamage)
	{
		zombieHealth -= weaponDamage;
	}


}