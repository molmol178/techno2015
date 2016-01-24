using UnityEngine;
using System.Collections;

public class GreatG1 : MonoBehaviour {

	public static bool greatanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.G)){
			print ("Greeeeeeeeeeeeeeeeaaaaaaaaaaaat");

			Destroy (other.gameObject);
			greatanotate = true;
		}
	}
}

