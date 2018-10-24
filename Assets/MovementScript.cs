using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
public CharacterController controller;

public float speed = 10f;
public float jumpPower = 10f;
public float gravity = 30f;

private Vector3 movement = Vector3.zero;

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () 
	{
		Movement();
	}

	void Movement()
	{
		if(controller.isGrounded)
		{
			movement = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
			movement = transform.TransformDirection(movement);
			movement *= speed;

			if(Input.GetKeyDown(KeyCode.Space))
			{
				movement.y = jumpPower;
			}
		}
		movement.y -= gravity * Time.deltaTime;
		 controller.Move(movement * Time.deltaTime);
	}
}
