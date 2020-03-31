using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnsChk : MonoBehaviour {
	public Button button1;
	public Button button2;
	public Button button3;
	public newsql newsql;


	void Logger(){
		Debug.Log (newsql.Checker);
	}

	public void Check(){
		Logger ();
		if (button1.GetComponentInChildren<Text> ().text == newsql.Checker) {
			correct ();
		} else {
			wrong ();
		} 
	}

	public void Check1(){
		if (button2.GetComponentInChildren<Text> ().text == newsql.Checker) {
			correct ();
		} else {
			wrong ();
		}
	}
	
	public	void Check2(){
		if (button3.GetComponentInChildren<Text> ().text == newsql.Checker) {
			correct ();
		} else {
			wrong ();
		} 
	}

	void correct(){
		Debug.Log("Correct");
	}
	
	void wrong(){
		Debug.Log("Wrong");
	}
}
