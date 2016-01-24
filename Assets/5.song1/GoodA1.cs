using UnityEngine;
using System.Collections;

public class GoodA1 : MonoBehaviour {

	public static bool goodanotate;
	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.A)) {
			print ("Gooooooooood!");

			Destroy (other.gameObject);
			goodanotate = true;
		}
	}
}

