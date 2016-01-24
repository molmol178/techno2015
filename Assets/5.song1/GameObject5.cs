using UnityEngine;
using System.Collections;

public class GameObject5 : MonoBehaviour {

	public AudioClip se;
	AudioSource SourceSe;

	void Start(){

		SourceSe = gameObject.GetComponent<AudioSource> ();
		SourceSe.clip = se;
	}
	
	void Update(){
		if (Input.GetKeyDown ("space")) {
			Application.LoadLevel ("scene7");
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			SourceSe.Play();
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			SourceSe.Play();
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			SourceSe.Play();
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			SourceSe.Play();
		}
		if (Input.GetKeyDown (KeyCode.G)) {
			SourceSe.Play();
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			SourceSe.Play();
		}
		if (Input.GetKeyDown (KeyCode.J)) {
			SourceSe.Play();
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			SourceSe.Play();
		}

	}
}
