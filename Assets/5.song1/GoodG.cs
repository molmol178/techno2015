using UnityEngine;
using System.Collections;

public class GoodG : MonoBehaviour {

	public static bool goodanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.G)) {
			print ("Gooooooooood!");

			Score.score += 2;
			Destroy (other.gameObject);
			goodanotate = true;
		}
	}
}

