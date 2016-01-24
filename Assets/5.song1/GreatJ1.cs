using UnityEngine;
using System.Collections;

public class GreatJ1 : MonoBehaviour {

	public static bool greatanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.J)){
			print ("Greeeeeeeeeeeeeeeeaaaaaaaaaaaat");

			Destroy (other.gameObject);
			greatanotate = true;
		}
	}
}

