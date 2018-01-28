using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

	// Use this for initialization

	public Button SoundButton;
	public Button BackButton;
	public Button ExitButton;

	public Animator SoundAnimator;
	public Animator BackAnimator;
	public Animator ExitAnimator;

	bool isActive;



	void Start () {

		isActive = false;
		SoundAnimator = SoundButton.GetComponent<Animator> ();
		BackAnimator = BackButton.GetComponent<Animator> ();
		ExitAnimator = ExitButton.GetComponent<Animator> ();

	}


	public void ActiveAnimation(){

		if(!isActive){
			
		SoundButton.gameObject.SetActive (true);
		BackButton.gameObject.SetActive (true);
		ExitButton.gameObject.SetActive (true);

		SoundAnimator.SetBool ("sound",true);
		BackAnimator.SetBool ("back",true);
		ExitAnimator.SetBool ("exit",true);

		isActive = true;

	}

		else {

			SoundButton.gameObject.SetActive (false); 
			BackButton.gameObject.SetActive (false);
			ExitButton.gameObject.SetActive (false);

			SoundAnimator.SetBool ("sound",false);
			BackAnimator.SetBool ("back",false);
			ExitAnimator.SetBool ("exit",false);

			isActive = false;

		}
}
}
