using UnityEngine;
using System.Collections;

public class GameObject2 : MonoBehaviour {

	public MovieTexture movieTexture;
	void Start() {
		movieTexture.Play ();
		
		
	}
		
		void Update(){
			if (Input.GetKeyDown ("space")) {
				Application.LoadLevel ("scene4");
			}
		}
		
}
