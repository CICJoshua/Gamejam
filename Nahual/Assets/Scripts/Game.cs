using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {
	public GameObject hero;
	public GameObject enemy;
	public Text txtMessage;
	public float distance = 5f;

	void Update ()
	{
		if(Mathf.Abs((hero.transform.position-enemy.transform.position).magnitude)<=distance)
			txtMessage.text="Hola";
		else
			txtMessage.text=string.Empty;
		
	}
}
