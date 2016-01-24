using UnityEngine;
using System.Collections;

public class GreatA1 : MonoBehaviour {

	public static bool greatanotate;


	public void OnTriggerStay(Collider other) {
		print ("attack AAAA");
		if (Input.GetKeyDown(KeyCode.A)){
			print ("Greeeeeeeeeeeeeeeeaaaaaaaaaaaat");

			Destroy (other.gameObject);
			greatanotate = true;
		}
	}
}

