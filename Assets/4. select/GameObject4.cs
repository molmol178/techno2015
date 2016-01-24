using UnityEngine;
using System.Collections;

public class GameObject4 : MonoBehaviour {

	public static string gameFlags;
	private AudioSource sound01;


		void Start(){
		Spownerdemo.demoasset = null;
		Spownerdemo.demokeysound = null;
		Spownerdemo.demosounds = 0;
		Spowner.keysound = null;
		Spowner.sounds = 0;
		AudioSource[] audioSources = GetComponents<AudioSource> ();
		sound01 = audioSources [0];

	}
		
		void Update(){
			if (Input.GetKeyDown ("s")) {
			sound01.PlayOneShot (sound01.clip);

				Application.LoadLevel ("scene1");
			gameFlags = "easy";
			}
			if (Input.GetKeyDown ("g")) {
			sound01.PlayOneShot (sound01.clip);

				Application.LoadLevel ("scene1");
			gameFlags = "normal";
		}
			if (Input.GetKeyDown ("j")) {
			sound01.PlayOneShot (sound01.clip);

				Application.LoadLevel ("scene1");
			gameFlags = "hard";
		}
		}
		
	
}
