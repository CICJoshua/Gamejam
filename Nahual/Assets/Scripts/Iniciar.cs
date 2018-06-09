using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour {
	
	void Update() {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("Bioma1", LoadSceneMode.Single);
            foreach (Transform child in GameObject.Find("Fogata").transform)
            {
                child.gameObject.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
            foreach (Transform child in GameObject.Find("Fogata").transform)
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}
