using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	public float thrust;
	public Rigidbody2D rb;
	private bool isGrounded = true;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
//  
	void FixedUpdate()
	{
		if(Input.GetKeyDown("space") && isGrounded == true){
		rb.AddForce(transform.up * thrust);
			isGrounded = false;
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		isGrounded = true;
	}
	
}