using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	public float damage;
	Transform firePoint;
	float maxSpeed = 3f;
	public GameObject bulletPrefab;


	// Use this for initialization
	void Awake () {
		firePoint = transform.FindChild ("FirePoint");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("f")){
			Fire ();
		}
	}

	public void Fire () {
		Instantiate (bulletPrefab);
	}
}