using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SettingsActiveGame : MonoBehaviour {

public GameObject settingsMenu;
public GameObject gameMenu;

	public void Settings()
	{
		gameMenu.SetActive(false);
		settingsMenu.SetActive(true);
	}
}
