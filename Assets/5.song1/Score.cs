using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {


	public static int score;
	public GUIText Scotx;

	void Awake (){
		score = 0;	
	}

	// Update is called once per frame
	public void Update () {
		Scotx.text = score.ToString ();
//		print ("count");
	}
}
