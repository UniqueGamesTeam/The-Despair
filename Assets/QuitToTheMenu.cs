﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitToTheMenu : MonoBehaviour {

	public void Quit()
	{
		SceneManager.LoadScene("MenuScene");
	}
}
