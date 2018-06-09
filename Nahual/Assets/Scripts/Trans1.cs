using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trans1 : MonoBehaviour {

	private bool bandera;

	void Awake(){
		bandera = true;
	}

	void OnCollisionEnter2D(Collision2D col){
		if (bandera) {
			SceneManager.LoadScene ("Transicion1", LoadSceneMode.Single);
			foreach (Transform child in GameObject.Find("Bioma1").transform) {
				child.gameObject.SetActive (false);

			}
			bandera = false;
		}
	}

	void OnCollisionExit2D(Collision2D col){
		if (!bandera) {
			bandera = true;
		}
	}
}
