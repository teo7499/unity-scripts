using UnityEngine;
using System.Collections;

public class collect : MonoBehaviour {

	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
		}
	}


}