using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public Scrollbar Mask;
	public float hp = 100;

	public void Damage(float value){
		hp -= value;
		Mask.size = hp / 100f;
	}

	void Update() {
		if (Input.GetKeyDown("h")){
			Debug.Log("HAND OF GOD");
			heal();
		}
	}

	void heal(){
		hp = hp+5;
	}
}
