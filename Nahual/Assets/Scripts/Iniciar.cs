using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour {
	
	void Update() {
		if (Input.GetKeyDown (KeyCode.A))
			SceneManager.LoadScene ("Bioma1", LoadSceneMode.Single);
	}
}
