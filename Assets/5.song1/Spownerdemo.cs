using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class Spownerdemo : MonoBehaviour {
	
	
	public int demoinote = 0;
	public IList demonotes = null;
	public int bpm = 86;
	public static string demokeysound;
	public static double demosounds;
	
	public Transform Ademo;
	public Transform Sdemo;
	public Transform Ddemo;
	public Transform Fdemo;
	public Transform Gdemo;
	public Transform Hdemo;
	public Transform Jdemo;
	public Transform Kdemo;
	public Transform Sounddemo;

	public static TextAsset demoasset;

	// Use this for initialization
	void Start () {
		demoasset = (TextAsset)Resources.Load("meto2out");
		string demojson = demoasset.text;
		demonotes = (IList)Json.Deserialize(demojson);
		
	}
	
	// Update is called once per frame
	void Update () {
		while (demoinote < demonotes.Count) {
			IDictionary note = (IDictionary)demonotes[demoinote];
			if(60 * 4 * (double)note["start"] > bpm * (Time.timeSinceLevelLoad)){
				break;
			}
			demokeysound = (string)note["key"];
			demosounds = (double)note["start"];
			CreateNote(demokeysound);
			startSound(demosounds);
			demoinote++;
			
			
		}
		
	}
	
	private void CreateNote(string demokeysound){
		switch (demokeysound) {
		case "0":
			Instantiate (Ademo, new Vector3 (-11, 12 ,0), Quaternion.identity);
			break;
		case "1":
			Instantiate (Sdemo, new Vector3 (-8, 12 ,0), Quaternion.identity);
			break;
		case "2":
			Instantiate (Ddemo, new Vector3(-5, 12 ,0), Quaternion.identity);
			break;
		case "3":
			Instantiate (Fdemo, new Vector3 (-1, 12 ,0), Quaternion.identity);
			break;
		case "4":
			Instantiate (Gdemo, new Vector3 (1, 12 ,0), Quaternion.identity);
			break;
		case "5":
			Instantiate (Hdemo, new Vector3 (5, 12 ,0), Quaternion.identity);
			break;
		case "6":
			Instantiate (Jdemo, new Vector3 (8, 12 ,0), Quaternion.identity);
			break;
		case "7":
			Instantiate (Kdemo, new Vector3 (11, 12 ,0), Quaternion.identity);
			break;
			
		default : break;
		}
	}
	
	private void startSound(double demosounds){
		if (demosounds == 1){
			Instantiate (Sounddemo, new Vector3 (15, 12 ,0), Quaternion.identity);
			
		}
	}
	
	
}