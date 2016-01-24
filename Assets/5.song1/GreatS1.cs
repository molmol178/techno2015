using UnityEngine;
using System.Collections;

public class GreatS1 : MonoBehaviour {

	public static bool greatanotate;


	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.S)){
			print ("Greeeeeeeeeeeeeeeeaaaaaaaaaaaat");

			Destroy (other.gameObject);
			greatanotate = true;
		}
	}
}

