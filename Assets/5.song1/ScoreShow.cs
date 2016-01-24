using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreShow : MonoBehaviour {

	public Text scoretext;
	public Transform success;
	public Transform miss;
	public bool successFlag;
	private AudioSource sound01;
	private AudioSource sound02;
	// Use this for initialization
	void Start () {
	 
		string sco;

		int s = Score.score;
		sco = s.ToString();

		AudioSource[] audioSources = GetComponents<AudioSource> ();
		sound01 = audioSources [0];
		sound02 = audioSources [1];


		if (GameObject4.gameFlags == "easy") {
			
			
			if (Score.score >= 100) {
				Instantiate (success, new Vector3 (934, 499, 0), Quaternion.identity);
				scoretext.text = sco;
				sound01.PlayOneShot (sound01.clip);
				
				successFlag = true;
			}
			if (Score.score < 100) {
				Instantiate (miss, new Vector3 (934, 499, 0), Quaternion.identity);
				scoretext.text = sco;
				sound02.PlayOneShot (sound02.clip);
				
				successFlag = false;
				
				
			}
		}
		if (GameObject4.gameFlags == "normal") {
			
			
			if (Score.score >= 200) {
				Instantiate (success, new Vector3 (934, 499, 0), Quaternion.identity);
				scoretext.text = sco;
				sound01.PlayOneShot (sound01.clip);
				
				successFlag = true;
			}
			if (Score.score < 200) {
				Instantiate (miss, new Vector3 (934, 499, 0), Quaternion.identity);
				scoretext.text = sco;
				sound02.PlayOneShot (sound02.clip);
				
				successFlag = false;
				
				
			}
		}
		if (GameObject4.gameFlags == "hard") {
			
			
			if (Score.score >= 400) {
				Instantiate (success, new Vector3 (934, 499, 0), Quaternion.identity);
				scoretext.text = sco;
				sound01.PlayOneShot (sound01.clip);
				
				successFlag = true;
			}
			if (Score.score < 400) {
				Instantiate (miss, new Vector3 (934, 499, 0), Quaternion.identity);
				scoretext.text = sco;
				sound02.PlayOneShot (sound02.clip);
				
				successFlag = false;
				
				
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if (successFlag == true) {
			if (Input.GetKeyDown ("space")) {
				Application.LoadLevel ("endingScene");
			}
		} else {
			if (Input.GetKeyDown ("space")) {
				Application.LoadLevel ("endingScene1");
			}
		
		}
		
	}
}
