using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class SetSensValue : MonoBehaviour {

public Slider musicSlider;
public MouseLook mouseSens;
public Text musicText;
	// Use this for initialization
	void Awake () 
	{
		musicSlider.value = PlayerPrefs.GetFloat("MouseSens");
	}
	
	// Update is called once per frame
	void Update () 
	{
		mouseSens.XSensitivity = musicSlider.value;
		mouseSens.YSensitivity = musicSlider.value;

		PlayerPrefs.SetFloat("MouseSens",musicSlider.value);
		

		musicText.text = musicSlider.value.ToString("0.##");
	}
}
