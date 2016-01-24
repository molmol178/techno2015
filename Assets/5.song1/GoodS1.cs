using UnityEngine;
using System.Collections;

public class GoodS1 : MonoBehaviour {

	public static bool goodanotate;


	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.S)) {
			print ("Gooooooooood!");

			Destroy (other.gameObject);
			goodanotate = true;
		}
	}
}

