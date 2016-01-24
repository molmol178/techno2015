using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class GreatView : MonoBehaviour {
	
	public Text greatView;
	
	// Update is called once per frame
	void Update () {
		
		if (GreatA.greatanotate == true ||GreatA1.greatanotate == true) {
			StartCoroutine ("Greater");
			GreatA.greatanotate = false;
			GreatA1.greatanotate = false;
		} 
		
		if (GreatS.greatanotate == true ||GreatS1.greatanotate == true) {
			StartCoroutine ("Greater");
			print ("SSSGJGJ");
			GreatS.greatanotate = false;
			GreatS1.greatanotate = false;
		}
		if (GreatD.greatanotate == true ||GreatD1.greatanotate == true) {
			StartCoroutine ("Greater");
			print ("DDDGJGJ");
			GreatD.greatanotate = false;
			GreatD1.greatanotate = false;
		}
		
		if (GreatF.greatanotate == true ||GreatF1.greatanotate == true) {
			StartCoroutine ("Greater");
			print ("FFFGJGJ");
			GreatF.greatanotate = false;
			GreatF1.greatanotate = false;
		}
		if (GreatG.greatanotate == true ||GreatG1.greatanotate == true) {
			StartCoroutine ("Greater");
			print ("GGGGJGJ");
			GreatG.greatanotate = false;
			GreatG1.greatanotate = false;
		}
		if (GreatH.greatanotate == true ||GreatH1.greatanotate == true) {
			StartCoroutine ("Greater");
			print ("HHHGJGJ");
			GreatH.greatanotate = false;
			GreatH1.greatanotate = false;
		}
		if (GreatJ.greatanotate == true ||GreatJ1.greatanotate == true) {
			StartCoroutine ("Greater");
			print ("JJJGJGJ");
			GreatJ.greatanotate = false;
			GreatJ1.greatanotate = false;
		}
		if (GreatK.greatanotate == true ||GreatK1.greatanotate == true) {
			StartCoroutine ("Greater");
			print ("KKKGJGJ");
			GreatK.greatanotate = false;
			GreatK1.greatanotate = false;
		}
	}
	
	IEnumerator Greater(){
		
		greatView.text = "Great!";
		yield return new WaitForSeconds(1.0f);
		greatView.text = null;
		
	}
	
}
