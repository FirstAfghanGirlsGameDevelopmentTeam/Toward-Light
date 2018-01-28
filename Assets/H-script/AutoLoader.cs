using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoLoader : MonoBehaviour {

	int counter=0;
	public int loadTime;
	public int scene;

	// Use this for initialization
	void Start(){
		InvokeRepeating ("Timer",0.001f,1f);
	}
	// Update is called once per frame
	void Update(){
		if(counter == loadTime){
			SceneLoader (scene);
		}
	}
	void Timer(){
		counter++;
	}

	void SceneLoader(int scene){
		SceneManager.LoadScene (scene);
	}


}