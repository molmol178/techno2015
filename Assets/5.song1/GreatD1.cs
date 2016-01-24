using UnityEngine;
using System.Collections;

public class GreatD1 : MonoBehaviour {

	public static bool greatanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.D)){
			print ("Greeeeeeeeeeeeeeeeaaaaaaaaaaaat");

			Destroy (other.gameObject);
			greatanotate = true;
		}
	}
}

