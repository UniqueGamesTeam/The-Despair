﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseScript : MonoBehaviour {

public bool pause = false;

public FirstPersonControllerFix movement;
public ShotAllow shoot;
public GameObject menu;
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			pause=true;
			movement.enabled=false;
			shoot.shoot = false;
			
			Cursor.visible = true;
			menu.SetActive(true);
			Time.timeScale = 0f;
		}
	}
}
