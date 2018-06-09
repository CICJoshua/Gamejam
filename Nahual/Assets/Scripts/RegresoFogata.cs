using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegresoFogata : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
   
        {
            SceneManager.LoadScene("Fogata", LoadSceneMode.Single);
            foreach (Transform child in GameObject.Find("Creditos").transform)
            {
                child.gameObject.SetActive(false);
            }
        }
		
	}
}
