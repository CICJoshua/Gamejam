using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour {

	public bool bandera = false;

	void Update() {

		if (Input.GetKeyDown (KeyCode.KeypadEnter))
			bandera = true;
		else if (Input.GetKeyDown (KeyCode.Return))
			bandera = true;

		if (bandera == true) 
		{
			SceneManager.LoadScene ("Bioma1", LoadSceneMode.Single);				
		}
	}
}
