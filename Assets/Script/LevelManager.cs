using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager: MonoBehaviour {
	public void LoadLevel(string name){
		Debug.Log ("Loading scene.." + name);	
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
}
