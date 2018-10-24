using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSounds : MonoBehaviour {

	// Use this for initialization
	public AudioClip[] ShotClips;
	public AudioSource audio;
	public ShotAllow shootFlag;
	
	// Update is called once per frame

	void Start()
	{
		audio.volume = 0.7f;
	}

	void Update () 
	{
		if(shootFlag.shoot == true)
		{
			if(Input.GetMouseButtonDown(0))
			{
				audio.clip = ShotClips[0];
				audio.PlayOneShot(audio.clip);
			}
		}
	}
}
