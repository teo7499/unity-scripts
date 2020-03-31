using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Projectile : MonoBehaviour {

	public float maxSpeed = 20f;
	public Rigidbody2D fireBall;



	public void clicked(){

		createShot ();
	}

	void createShot ()
	{
		Rigidbody2D bulletInstance = Instantiate(fireBall, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
		bulletInstance.velocity = new Vector2(maxSpeed, 0);
}
}
 