using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnAwakeScript : MonoBehaviour {
public AudioSource music;
public AudioSource sounds;
public Slider musicSlider;
public Slider soundsSlider;
	// Use this for initialization
	void Awake () 
	{
		Time.timeScale = 1f;
		if(PlayerPrefs.GetFloat("MusicVolume")==0)
		{
			musicSlider.value=0.2f;
			soundsSlider.value=0.2f;
			music.volume  = musicSlider.value;
			sounds.volume = soundsSlider.value;
		}
		else
		{
			musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
			soundsSlider.value = PlayerPrefs.GetFloat("SoundVolume");
			music.volume = musicSlider.value;	
			sounds.volume = soundsSlider.value;
			
		}
		

	}
	

}
