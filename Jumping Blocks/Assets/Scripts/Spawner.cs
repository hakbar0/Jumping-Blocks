using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject enemy;

	// Use this for initialization
	void Start () {
		Invoke("SpawnBlock", 2f);

	}
	
	void SpawnBlock(){
		GameObject instance = Instantiate (enemy);
		instance.transform.position = new Vector2(7f, -3f);
		float randomTime = Random.Range(0.5f, 1.2f); 
		Invoke("SpawnBlock", randomTime);
	}
}
