using UnityEngine;
using System.Collections;

public class Remover : MonoBehaviour {
	public static bool badanotate;

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		print ("destroy");
		Score.score -= 3;

		badanotate = true;

	}
}