using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class Spowner : MonoBehaviour {


	public int inote = 0;
	public IList notes = null;
	public int bpm = 0;
	public static string keysound;
	public static double sounds;

	public Transform A;
	public Transform S;
	public Transform D;
	public Transform F;
	public Transform G;
	public Transform H;
	public Transform J;
	public Transform K;
	public Transform Sound;

	TextAsset asset = null;


	// Use this for initialization
	void Start () {
		inote = 0;
		keysound = null;
		sounds = 0;


		if (GameObject4.gameFlags == "easy") {
			
			asset = (TextAsset)Resources.Load ("easy-toruko");
			string json = asset.text;
			notes = (IList)Json.Deserialize(json);
			bpm = 240;
			
		}
		if (GameObject4.gameFlags == "normal") {
			
			asset = (TextAsset)Resources.Load ("normal-kakumei");
			string json = asset.text;
			notes = (IList)Json.Deserialize(json);
			bpm = 145;
		}
		if (GameObject4.gameFlags == "hard") {
			
			asset = (TextAsset)Resources.Load ("hard-kusikosu");
			string json = asset.text;
			notes = (IList)Json.Deserialize(json);
			bpm = 150;
		}

	}
	
	// Update is called once per frame
	void Update () {
  		while (inote < notes.Count) {
				IDictionary note = (IDictionary)notes[inote];
			if(60 * 4 * (double)note["start"] > bpm * (Time.timeSinceLevelLoad)){
					break;
				}
				keysound = (string)note["key"];
				sounds = (double)note["start"];
				CreateNote(keysound);
				startSound(sounds);
				inote++;

				
			}

	}

	private void CreateNote(string keysound){
		switch (keysound) {
		case "0":
			Instantiate (A, new Vector3 (-11, 15 ,0), Quaternion.identity);
			break;
		case "1":
			Instantiate (S, new Vector3 (-8, 15,0), Quaternion.identity);
			break;
		case "2":
			Instantiate (D, new Vector3(-5, 15,0), Quaternion.identity);
			break;
		case "3":
			Instantiate (F, new Vector3 (-1, 15 ,0), Quaternion.identity);
			break;
		case "4":
			Instantiate (G, new Vector3 (1, 15,0), Quaternion.identity);
			break;
		case "5":
			Instantiate (H, new Vector3 (5, 15,0), Quaternion.identity);
			break;
		case "6":
			Instantiate (J, new Vector3 (8, 15,0), Quaternion.identity);
			break;
		case "7":
			Instantiate (K, new Vector3 (11, 15,0), Quaternion.identity);
			break;
	
		default : break;
		}
	}


	private void startSound(double sounds){
		if (GameObject4.gameFlags == "normal" || GameObject4.gameFlags == "hard") {
			if (sounds == 1.0) {
				print("soundtest");

				Instantiate (Sound, new Vector3 (15, 15, 0), Quaternion.identity);
			}
		}
		if (GameObject4.gameFlags == "easy"){
			if (sounds == 1.5){
				print("soundtest");
				
			Instantiate (Sound, new Vector3 (15, 15 ,0), Quaternion.identity);
			}
		}
	}

}