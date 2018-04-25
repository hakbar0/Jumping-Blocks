using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject enemy;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnBlock", 0f, 2f);

	}
	
	void SpawnBlock(){
		GameObject instance = Instantiate (enemy);
		instance.transform.position = new Vector2(0f, 0f);
	}
}
