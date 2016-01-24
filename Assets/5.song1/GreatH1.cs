using UnityEngine;
using System.Collections;

public class GreatH1 : MonoBehaviour {

	public static bool greatanotate;


	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.H)){
			print ("Greeeeeeeeeeeeeeeeaaaaaaaaaaaat");

			Destroy (other.gameObject);
			greatanotate = true;
		}
	}
}

