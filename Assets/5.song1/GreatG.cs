﻿using UnityEngine;
using System.Collections;

public class GreatG : MonoBehaviour {

	public static bool greatanotate;



	public void OnTriggerStay(Collider other) {

		if (Input.GetKeyDown(KeyCode.G)){
			print ("Greeeeeeeeeeeeeeeeaaaaaaaaaaaat");

			Score.score += 5;
			Destroy (other.gameObject);
			greatanotate = true;
		}
	}
}

