using UnityEngine;
using System.Collections;

public class GoodH : MonoBehaviour {

	public static bool goodanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.H)) {
			print ("Gooooooooood!");
			goodanotate = true;

			Score.score += 2;
			Destroy (other.gameObject);
		}
	}
}

