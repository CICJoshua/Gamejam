using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour {

	public int p1, p2, p3;
	
	void Awake(){
		p1=0;
		p2=0;
		p3=0;
	}
/*	
	void OnCollisionEnter2D(Collision2D col_peyote){
		if(col_peyote.gameObject.tag == "peyote_verde")
			p1++;
		if(col_peyote.gameObject.tag == "peyote_naranja")
			p2++;
		if(col_peyote.gameObject.tag == "peyote_rosa")
			p3++;
		if (col_peyote.gameObject.tag == "peyote_dorado")
			Destroy (gameObject, .5f);
	}
	*/

	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
		p3++;
	}
}