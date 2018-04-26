using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;


public class DB : MonoBehaviour {



	// Use this for initialization
	void Start () {
		FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://jumping-blocks.firebaseio.com/");
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
		FirebaseDatabase.DefaultInstance
			.GetReference("jumping-blocks")
			.ValueChanged += HandleValueChanged;
	}

	void HandleValueChanged(object sender, ValueChangedEventArgs args) {
		if (args.DatabaseError != null) {
			Debug.LogError (args.DatabaseError.Message);
			return;
		}
		print (args.Snapshot);
	}

}
