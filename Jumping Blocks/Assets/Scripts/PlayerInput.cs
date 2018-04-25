using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	public float thrust;
	public Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
		
	void FixedUpdate()
	{
		if(Input.GetKeyDown("space")){
		rb.AddForce(transform.up * thrust);
		}
	}
	
}