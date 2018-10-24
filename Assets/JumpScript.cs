using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {

public Rigidbody rb;
public float JumpPower;
public float speed = 10f;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Jump();
	}
	void Jump()
	{
		float moveH = Input.GetAxis("Horizontal");
		float moveV = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveH,0,moveV);

		rb.AddForce(movement * speed);
		if(Input.GetKeyDown(KeyCode.Space))
		{
				rb.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
		}
	}
}
