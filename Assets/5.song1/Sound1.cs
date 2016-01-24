using UnityEngine;
using System.Collections;


public class Sound1 : MonoBehaviour {
	
	private AudioSource sound01;


	bool demoFlag =false;
	
	// Use this for initialization
	void Start () {
		AudioSource[] audioSources = GetComponents<AudioSource> ();
		sound01 = audioSources [0];


		foreach (var i in audioSources)
		{
			print(i.clip);
		}
	}


	public void OnTriggerEnter(Collider other) {
		
		if (!demoFlag) {
				
			sound01.PlayOneShot (sound01.clip);
			demoFlag = true;
		}
	}

	}


