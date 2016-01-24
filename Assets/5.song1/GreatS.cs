using UnityEngine;
using System.Collections;

public class GreatS : MonoBehaviour {

	public static bool greatanotate;


	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.S)){
			print ("Greeeeeeeeeeeeeeeeaaaaaaaaaaaat");

			Score.score += 5;
			Destroy (other.gameObject);
			greatanotate = true;
		}
	}
}

