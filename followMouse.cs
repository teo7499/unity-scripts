using UnityEngine;
using System.Collections;

public class followMouse : MonoBehaviour {

	public float speed = 350f;
	private Vector3 target;

	void Start () {
		target = transform.position;
	}
	
	void Update () {
	
			target.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
			target.z = transform.position.z;
			transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}   

}
