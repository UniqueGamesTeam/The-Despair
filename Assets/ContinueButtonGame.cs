using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ContinueButtonGame : MonoBehaviour {

public FirstPersonControllerFix mouseLook;
public ShotAllow shoot;
public GameObject menu;

	public void Continue()
	{
		menu.SetActive(false);
		mouseLook.enabled = true;
		shoot.shoot = true;
		Time.timeScale = 1f;
	}
	
}
