using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	private Animator anim;
	private Rigidbody2D rb2d;
	public float moveForce = 200f;
	public float maxSpeed = 5f;

	// Use this for initialization
	void Awake () 
	{
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		float h = Input.GetAxis ("Horizontal");
		
		anim.SetFloat ("Speed", Mathf.Abs (h));
		
		if (h * rb2d.velocity.x < maxSpeed)
			rb2d.AddForce (Vector2.right * h * moveForce);
		
		if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
			rb2d.velocity = new Vector2 (Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);
		
		if (h > 0 && !facingRight)
			Flip ();
		else if (h < 0 && facingRight)
			Flip ();
	}

	//To flip the sprite
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

}
