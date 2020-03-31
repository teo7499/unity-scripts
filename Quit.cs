using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {
	
	void Update () {
		if(Input.GetKeyUp(KeyCode.Q))
		{
			Application.Quit();
			UnityEditor.EditorApplication.isPlaying = false;
		}
	}
}
