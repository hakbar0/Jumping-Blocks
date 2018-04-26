using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Enemy : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		Destroy (other.gameObject);
	}
}
