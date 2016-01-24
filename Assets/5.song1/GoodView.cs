using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class GoodView : MonoBehaviour {

	public Text goodView;
		
	// Update is called once per frame
	void Update () {

		if (GoodA.goodanotate == true || GoodA1.goodanotate == true) {
			StartCoroutine ("Gooder");
			GoodA.goodanotate = false;
			GoodA1.goodanotate = false;
		} 

		if (GoodS.goodanotate == true || GoodS1.goodanotate == true) {
			StartCoroutine ("Gooder");
			print ("SSSGJGJ");
			GoodS.goodanotate = false;
			GoodS1.goodanotate = false;
		}
		if (GoodD.goodanotate == true || GoodD1.goodanotate == true) {
			StartCoroutine ("Gooder");
			print ("DDDGJGJ");
			GoodD.goodanotate = false;
			GoodD1.goodanotate = false;
		}

		if (GoodF.goodanotate == true || GoodF1.goodanotate == true) {
			StartCoroutine ("Gooder");
			print ("FFFGJGJ");
			GoodF.goodanotate = false;
			GoodF1.goodanotate = false;
		}
		if (GoodG.goodanotate == true || GoodG1.goodanotate == true) {
			StartCoroutine ("Gooder");
			print ("GGGGJGJ");
			GoodG.goodanotate = false;
			GoodG1.goodanotate = false;
		}
		if (GoodH.goodanotate == true || GoodH1.goodanotate == true) {
			StartCoroutine ("Gooder");
			print ("HHHGJGJ");
			GoodH.goodanotate = false;
			GoodH1.goodanotate = false;
		}
		if (GoodJ.goodanotate == true || GoodJ1.goodanotate == true) {
			StartCoroutine ("Gooder");
			print ("JJJGJGJ");
			GoodJ.goodanotate = false;
			GoodJ1.goodanotate = false;
		}
		if (GoodK.goodanotate == true || GoodK1.goodanotate == true) {
			StartCoroutine ("Gooder");
			print ("KKKGJGJ");
			GoodK.goodanotate = false;
			GoodK1.goodanotate = false;
		}
	}

	IEnumerator Gooder(){
	
			goodView.text = "Good!";
			yield return new WaitForSeconds(1.0f);
		goodView.text = null;

	}

}
