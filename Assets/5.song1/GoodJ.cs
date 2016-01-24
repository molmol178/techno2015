using UnityEngine;
using System.Collections;

public class GoodJ : MonoBehaviour {

	public static bool goodanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.J)) {
			print ("Gooooooooood!");

			Score.score += 2;
			Destroy (other.gameObject);
			goodanotate = true;
		}
	}
}

