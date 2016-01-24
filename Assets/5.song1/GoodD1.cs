using UnityEngine;
using System.Collections;

public class GoodD1 : MonoBehaviour {

	public static bool goodanotate;




	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.D)) {
			print ("Gooooooooood!");

			Destroy (other.gameObject);
			goodanotate = true;
		}
	}
}

