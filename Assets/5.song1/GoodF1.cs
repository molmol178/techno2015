using UnityEngine;
using System.Collections;

public class GoodF1 : MonoBehaviour {

	public static bool goodanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.F)) {
			print ("Gooooooooood!");
			goodanotate = true;
			Destroy (other.gameObject);
		}
	}


}

