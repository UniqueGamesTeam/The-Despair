using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoil : MonoBehaviour {

public GameObject mainCamera;

 
void Start ()
  {
		
  }
 
void Update ()
    {
        mainCamera.transform.Rotate(Vector3.up, 20.0f * Time.deltaTime);
				Debug.Log("CAMERA!!!");
		}
  }