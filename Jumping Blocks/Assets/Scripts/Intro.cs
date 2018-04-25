using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

	void Start () {
		StartCoroutine (firstScene ());
	}
	
	IEnumerator firstScene(){
		yield return new WaitForSeconds (7);
		SceneManager.LoadScene ("1_menu");
	}
}
