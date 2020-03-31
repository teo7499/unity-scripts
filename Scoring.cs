using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

	public int Score = 0;
	public Text countText;

	// Use this for initialization

	public void correct(){
		Score++;
	}
	
	void Update(){
		countText.text = "score: " + Score.ToString ();
	}

	public void wrong(){
		if (Score > 0) {
			Score--;
		} else 
			Score = 0;
	}

}
