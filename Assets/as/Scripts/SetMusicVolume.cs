using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMusicVolume : MonoBehaviour {

public Slider musicSlider;
public AudioSource musicSource;
public Text musicText;
	// Use this for initialization
	void Awake () 
	{
		musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
	}
	
	// Update is called once per frame
	void Update () 
	{
		musicSource.volume = musicSlider.value;
		PlayerPrefs.SetFloat("MusicVolume",musicSlider.value);
		musicText.text = musicSlider.value.ToString("0.##");
	}
}
