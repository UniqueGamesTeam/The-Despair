using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsKick : MonoBehaviour {

public Animator handsKickAnim;
public GameObject AttackCollider;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () 
	{
			if(Input.GetMouseButtonDown(0))
		{
			handsKickAnim.SetBool("RightKick",true);
		}
	}
	IEnumerator Kick()
	{
	
			
			AttackCollider.SetActive(true);

			yield return new WaitForSeconds(0.1f);
			AttackCollider.SetActive(false);
			handsKickAnim.SetBool("RightKick",false);
			
			
			
		}
			
	}

