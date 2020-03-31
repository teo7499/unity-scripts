using UnityEngine;
using System.Collections;

public class reset : MonoBehaviour {
	
	void Update () {
		if(Input.GetKeyUp(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
