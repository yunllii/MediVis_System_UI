using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Control : MonoBehaviour {

	Animator Anim;
	bool Once=false;
	// Use this for initialization
	void Start () {
		Anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {



		if (Input.GetKeyDown("space") && Once == false){


			Once = true;

			StartCoroutine(TimedOpen());


		}

				
	}

	IEnumerator TimedOpen(){
		Anim.SetTrigger ("open_system");
		yield return new WaitForSeconds(5);

		Debug.Log ("Hahahaha");
	}

}
