using UnityEngine;
using System.Collections;

public class GoodK1 : MonoBehaviour {

	public static bool goodanotate;




	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.K)) {
			print ("Gooooooooood!");

			Destroy (other.gameObject);
			goodanotate = true;
		}
	}
}

