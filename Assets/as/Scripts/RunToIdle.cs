using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class RunToIdle : MonoBehaviour {


	public Animator animator;
	public bool runInAnim=false;
	public FirstPersonControllerFix allowRuning;
	// Update is called once per frame
	void Update () 
	{
		if(runInAnim==true && Input.GetMouseButtonDown(0))
		{
			animator.SetBool("ShotWhileRun",true);
			animator.SetBool("RunWithPistol",false);
			runInAnim=false;
			allowRuning.m_IsWalking=true;
			Debug.Log("WALK!");
		
		}
	}

	void Run()
	{
		runInAnim=true;
		allowRuning.m_IsWalking=false; 
	}
	void NoRun()
	{
		allowRuning.m_IsWalking=true; 
		runInAnim=false;
	}
}


