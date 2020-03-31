using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotForAns : MonoBehaviour, IDropHandler {

	public GameObject item {
		get {
			if(transform.childCount>0){
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}
	
	#region IDropHandler implementation
	
	public void OnDrop (PointerEventData eventData)
	{
		
		if (!item) {
			
			Draggable.itemBeingDragged.transform.SetParent (transform);

			if (correctAnswer.name == item.name)
			{

//				Firepoint.CompareTag("Bullet");

				GameObject go = (GameObject) Instantiate (FireballPrefab);
				go.transform.position = new Vector3 (133,315f, 1.5f);
				
				Rigidbody2D Miss = Instantiate(FireballPrefab1, go.transform.position, Quaternion.Euler(new Vector3(0,0, -360))) as Rigidbody2D;
				Miss.velocity = new Vector2(maxSpeed, 0);

				gamesql = gamesql.GetComponent<Gamesql>();
				gamesql.activation();

				correct();
			}
			else
			{
				gamesql = gamesql.GetComponent<Gamesql>();
				gamesql.activation();
				wrong ();
			}
		}
	}
	
	#endregion


	// Game object of Correct Ans
	public GameObject correctAnswer; 

	//Scoring 
	int Scoring = 0;
	public Text countText;

	public void correct ()
	{
		Scoring++;
	}
	
	public void wrong ()
	{
		
		if (Scoring > 0) {
			Scoring = Scoring - 1;
		} else
			Scoring = 0;
		
	}
	
	void Update ()
	{
		
		countText.text = "Score: " + Scoring.ToString ();
		//Application.LoadLevel(0);
		
	}
	//End of Scoring


	//Game Object for Fighting 
	public GameObject FireballPrefab;
	public Rigidbody2D FireballPrefab1;

	public float maxSpeed = 350f;

//	//public FireBall fireBall; 
//	public GameObject Firepoint;

	//Script reference from GameSql
	public Gamesql gamesql;

}

