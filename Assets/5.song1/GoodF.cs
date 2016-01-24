using UnityEngine;
using System.Collections;

public class GoodF : MonoBehaviour {

	public static bool goodanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.F)) {
			print ("Gooooooooood!");
			goodanotate = true;
			Score.score += 2;
			Destroy (other.gameObject);
		}
	}


}

