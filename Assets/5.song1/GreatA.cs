using UnityEngine;
using System.Collections;

public class GreatA : MonoBehaviour {

	public static bool greatanotate;


	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.A)){
			print ("Greeeeeeeeeeeeeeeeaaaaaaaaaaaat");

			Score.score += 5;
			Destroy (other.gameObject);
			greatanotate = true;
		}
	}
}

