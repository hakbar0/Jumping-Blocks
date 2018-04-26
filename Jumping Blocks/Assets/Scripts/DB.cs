using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public class DB: MonoBehaviour {
	public long topScore = 0;

	public float playerScore = 0f;

	private DatabaseReference db;

	public Text text;


	void Awake() {
		playerScore =  GameObject.FindObjectOfType<ScoreKeeper>().score;
	}

	void Start() {
		// Set this before calling into the realtime database.
		FirebaseApp.DefaultInstance.SetEditorDatabaseUrl ("https://jumping-blocks.firebaseio.com/");

		// Get the root reference location of the database, from which we will operate on the database.
		db = FirebaseDatabase.DefaultInstance.GetReference ("scores");

		GetTopScore ();

	}


	 void GetTopScore(){
		db.GetValueAsync().ContinueWith(task => {
			if (task.IsFaulted) {
				Debug.Log("error");
			}
			else if (task.IsCompleted) {
				Dictionary<string, object> results = (Dictionary<string, object>) task.Result.Value;
				topScore = (long) results["topScore"];
				print(topScore);
				print(playerScore);
				if(playerScore > topScore){
					PushToDB(playerScore);
					text.text = "World Score: " + playerScore;
				}
				else  {
					text.text = "World Score: " + topScore;
				}
			}
		});
	
	}

	 void PushToDB(float PlayerScore){
		db.Child ("topScore").SetValueAsync (PlayerScore);
	}




}