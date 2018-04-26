using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {

	public Text text;

	void Start () {
		float score = GameObject.FindObjectOfType<ScoreKeeper>().score;
		text.text = "Score: " + score;
		Destroy (GameObject.Find ("ScoreKeeper"));
	}
}
