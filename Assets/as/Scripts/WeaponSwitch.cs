using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour {

public GameObject LeftHand;
public GameObject RightHand;

public GameObject Pistol;

public AudioClip[] ShotClips;
public AudioSource audio;

	// Use this for initialization
	void Start()
	{
		audio.volume = 0.7f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown("1"))
		{
			LeftHand.SetActive(true);
			RightHand.SetActive(true);

			Pistol.SetActive(false);
		}

		if(Input.GetKeyDown("2"))
		{
			audio.clip = ShotClips[0];
			audio.PlayOneShot(audio.clip);

			LeftHand.SetActive(false);
			RightHand.SetActive(false);

			Pistol.SetActive(true);
		}

	}
}
