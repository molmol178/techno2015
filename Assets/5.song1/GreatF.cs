using UnityEngine;
using System.Collections;

public class GreatF : MonoBehaviour {

	public static bool greatanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.F)){
			print ("Greeeeeeeeeeeeeeeeaaaaaaaaaaaat");

			Score.score += 5;
			Destroy (other.gameObject);
			greatanotate = true;
		}
	}
}

