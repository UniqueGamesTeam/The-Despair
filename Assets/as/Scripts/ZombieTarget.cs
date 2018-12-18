using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ZombieTarget : MonoBehaviour {

	// Use this for initialization
	public ZombieHP DeadStatus;
	public NavMeshAgent zombieNavMesh;
	public Transform player;
	public Transform zombie;
	public Animator zombieAnim;
	public SphereCollider sphereCollider;
	void Start()
	{
		zombie = GetComponent<Transform>();
		
	}
	public void OnTriggerEnter(Collider sphereCollider)
	{
		if(DeadStatus.isDead==false)
		{
			if(sphereCollider.gameObject.tag == "Main_Player")
			{
				Debug.Log("ZZZZ");
				zombieNavMesh.SetDestination(player.position);
				zombieAnim.SetBool("Attack",true);
			}
		}
	}
	void Update()
	{
		if (DeadStatus.isDead==true)
		{
			zombieNavMesh.SetDestination(zombie.position);
			zombieAnim.SetBool("Attack",false);
		}
	}
}
