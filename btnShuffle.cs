void BtnTxt(){
		// UnityEngine.Random.Range (0, Options.Length)

		Shuffle (Options);
		for (int i = 0; i < 3; i++) {
			Button [i].GetComponentInChildren<Text> ().text = Options [i];

		}
	}

	void Shuffle(String[] a){
		// Loops through array
		for (int i = a.Length-1; i > 0; i--)
		{
			// Randomize a number between 0 and i (so that the range decreases each time)
			int rnd = UnityEngine.Random.Range(0,i);
			
			// Save the value of the current i, otherwise it'll overright when we swap the values
			String temp = a[i];
			
			// Swap the new and old values
			a[i] = a[rnd];
			a[rnd] = temp;
		}
		
		// Print
		for (int i = 0; i < a.Length; i++)
		{
			Debug.Log (a[i]);
		}
		
		}