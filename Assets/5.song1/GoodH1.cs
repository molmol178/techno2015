using UnityEngine;
using System.Collections;

public class GoodH1 : MonoBehaviour {

	public static bool goodanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.H)) {
			print ("Gooooooooood!");
			goodanotate = true;

			Destroy (other.gameObject);
		}
	}
}

