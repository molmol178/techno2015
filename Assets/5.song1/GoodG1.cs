using UnityEngine;
using System.Collections;

public class GoodG1 : MonoBehaviour {

	public static bool goodanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.G)) {
			print ("Gooooooooood!");

			Destroy (other.gameObject);
			goodanotate = true;
		}
	}
}

