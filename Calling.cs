using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calling : MonoBehaviour {
	

	// Update is called once per frame
	void ShootOnClick () {
		GetComponent<shoot>().Fire();
	}
}
