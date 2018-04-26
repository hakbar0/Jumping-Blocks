using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

	public float score = 0f;
	public Text text;

	void Start () {
		InvokeRepeating ("Scoring", 1.0f, 1.0f);
	}

	void Scoring(){
		score++;
		text.text = "Score: " + score;
	}

	
	void Awake()
	{
		DontDestroyOnLoad(this);
	}
}
