using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsScipt : MonoBehaviour {

public int BulletsInClip = 8;
public int BulletsLeft = 16;
public int bull;

public Text bulletsUI;
public Animator reloadAnim;
public ShotAllow shootScript;
	// Use this for initialization

	void Start()
	{
		BulletsInClip = 8;
		bulletsUI.text = BulletsInClip.ToString()+"/" + BulletsLeft.ToString();
	}



	
	// Update is called once per frame
	void Update () 
	{
		bulletsUI.text = BulletsInClip.ToString()+"/" + BulletsLeft.ToString();

		if(Input.GetMouseButtonDown(0))
		{
			if(shootScript.shoot == true)
			{
			if(BulletsInClip>0)
			{
				shootScript.shoot = true;
				BulletsInClip-=1;
			}
			else
			{
				shootScript.shoot = false;
			}
			}
		}

		if(BulletsInClip==0)
		{
			bulletsUI.text = "0"+"/" + BulletsLeft.ToString();
			shootScript.shoot = false;
			BulletsInClip=0;
		}

		////////////////////////////
		
		StartCoroutine(Reload());
		////////////////////////////
	}
	IEnumerator Reload()
	{
		if(BulletsLeft>0)
		{
			if(Input.GetKeyDown(KeyCode.R))
			{
				if(BulletsInClip+BulletsLeft<=8)
				{
					reloadAnim.SetBool("Reload",true);
					yield return new WaitForSeconds(2); 
					reloadAnim.SetBool("Reload",false);
					BulletsInClip += BulletsLeft;
					BulletsLeft=0;
				}
				
				if(BulletsInClip<8 && BulletsLeft>0)
				{
					reloadAnim.SetBool("Reload",true);

					yield return new WaitForSeconds(2);

					reloadAnim.SetBool("Reload",false);
					BulletsLeft -=  (8 - BulletsInClip);
					BulletsInClip = 8 ;
				}
			}
		}
	}
}
