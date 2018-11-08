using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHP : MonoBehaviour {

	// Use this for initialization
	public float zombieHealth;
    public GameObject Zombie;
    public save_script save;

	Animator zombieAnimator;

    void Start () 
	{
		this.zombieHealth = 60f;
		this.zombieAnimator = GetComponent<Animator>();
	}

	void Update()
	{
        
       // Debug.Log(Zombie.transform.position);
        if (this.zombieHealth<=0)
			{
            //Set Animatior
            //Zombie.SetActive(false);
			this.zombieAnimator.SetBool("Die",true);
            Debug.Log(Zombie.name);
            Debug.Log(this.Zombie.transform.position.x);
            save.DeadZombies(this.Zombie.name, this.Zombie.transform.position.x, this.Zombie.transform.position.y, this.Zombie.transform.position.z);
        }
		//Debug.Log(zombieHealth);
	}
	void ZombieHealth(float weaponDamage)
	{
		zombieHealth -= weaponDamage;
	}


}