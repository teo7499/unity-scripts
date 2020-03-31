using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour {
	
	public int score;
	public Text countText;

	void Start () {
		score = 0;
		SetCountText ();
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Pick Up")) {

			score++;
			SetCountText();
		}
	}

	void SetCountText ()
	{
		countText.text = "score: " + score.ToString ();
	}
}
