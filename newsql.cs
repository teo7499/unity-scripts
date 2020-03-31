using UnityEngine;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
	
public class newsql : MonoBehaviour {

		// In truth, the only things you want to save to the database are dynamic objects
		// static objects in the scene will always exist, so make sure to set your Tag 
		// based on the documentation for this demo
		
		// values to match the database columns
		public string quest;
		string Question, correct, wrong1, wrong2; 
		int ID, n;
		public Text qns, correctp, wrong1p, wrong2p;
		bool saving = false;
		bool loading = false;
		// MySQL instance specific items
		string constr = "Server=127.0.0.1;Database=demo;User ID=root;Password=password;Pooling=true";
		// connection object
		MySqlConnection con = null;
		// command object
		MySqlCommand cmd = null;
		// reader object
		MySqlDataReader rdr = null;
		// object collection array
		GameObject[] bodies;
		// object definitions
		public struct data
		{
			public int ID;
			public string Question, correct, wrong1, wrong2; 
		}
		// collection container
		List<data> _GameItems;
		void Awake()
		{
			try
			{
				// setup the connection element
				con = new MySqlConnection(constr);
				
				// lets see if we can open the connection
				con.Open();
				Debug.Log("Connection State: " + con.State);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
			
		}
		
		void OnApplicationQuit()
		{
			Debug.Log("killing con");
			if (con != null)
			{
				if (con.State.ToString() != "Closed")
					con.Close();
				con.Dispose();
			}
		}
		// Read all entries from the table
		public void ReadEntries()
		{
			string query = string.Empty;
			if (_GameItems == null)
				_GameItems = new List<data>();
			if (_GameItems.Count > 0)
				_GameItems.Clear();
			// Error trapping in the simplest form
			try
			{
				query = "SELECT * FROM view_demo WHERE ID =" +n ;
				if (con.State.ToString() != "Open")
					con.Open();
				using (con)
				{
					using (cmd = new MySqlCommand(query, con))
					{
						rdr = cmd.ExecuteReader();
						if (rdr.HasRows)
							while (rdr.Read())
						{
							data itm = new data();
							itm.ID = int.Parse(rdr["ID"].ToString());
							itm.Question = rdr["Question"].ToString();
							quest = itm.Question;
							itm.wrong1 = rdr["wrong1"].ToString();
							itm.wrong2 = rdr["wrong2"].ToString();
							itm.correct = rdr["correct"].ToString(); 
							_GameItems.Add(itm);
						}
						rdr.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
			finally
			{
			}
		}

		public void LogGameItems()
		{
		foreach (data itm in _GameItems) {
			Debug.Log ("ID: " + itm.ID);
			qns.text = itm.Question;
			correctp.text=itm.correct;
			wrong1p.text=itm.wrong1;
			wrong2p.text=itm.wrong2;
		}
		}
		void randnum(){
			n = UnityEngine.Random.Range (1, 30);
		}

		void Start(){
			randnum ();
			Debug.Log ("Started");
			ReadEntries ();
			LogGameItems ();
	}

		void Update()
		   {
			if (Input.GetKeyDown (KeyCode.L)) {
				randnum();
				Debug.Log("LOADED");
				ReadEntries();
				LogGameItems();
			}
		   }
}
