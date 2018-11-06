using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ZombieTarget : MonoBehaviour {

	// Use this for initialization
	
	public NavMeshAgent zombieNavMesh;
	public Transform player;
	
	public void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.tag == "Main_Player")
		{
			Debug.Log("ZZZZ");
			
			zombieNavMesh.SetDestination(player.position);
		}

	}


}
