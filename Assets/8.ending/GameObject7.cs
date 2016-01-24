using UnityEngine;
using System.Collections;

public class GameObject7 : MonoBehaviour {

	public MovieTexture movieTexture;
	void Start() {
			movieTexture.Play ();


	}


	
	void Update(){
		if (Input.GetKeyDown ("space")) {
			Application.LoadLevel ("title");
		}
	}
}