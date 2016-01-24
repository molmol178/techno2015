using UnityEngine;
using System.Collections;

public class GameObject : MonoBehaviour {


	void Update(){
		if (Input.GetKeyDown ("space")) {
			Application.LoadLevel ("scene8");

		}
		if (Input.GetKeyDown ("p")) {
			Application.LoadLevel ("scene6");

		}
	}

}