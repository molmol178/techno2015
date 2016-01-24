using UnityEngine;
using System.Collections;

public class GoodK : MonoBehaviour {

	public static bool goodanotate;




	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.K)) {
			print ("Gooooooooood!");

			Score.score += 2;
			Destroy (other.gameObject);
			goodanotate = true;
		}
	}
}

