using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurManager : MonoBehaviour 
{
	public float speedX; //Velocidad en eje x
	public float jumpSpeedY; //velocidad de salto

	bool facingRight, Jumping; //bool para comprobar avance a la derecha y de salto
	float speed; //variable para avance

	public Animator anim; //variable declarada
	public Rigidbody2D rb; //variable para alterar propiedades fisicas especificas

	// Use para inicializar
	void Start () 
	{
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D>(); 
		facingRight = true;
	}
	
	// Update es llamada una vez por cuadro
	void Update ()
	{
		//Movimiento del jugador 
		MovePlayer (speed);
		 

		//Movimiento con control izquierdo
		if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			speed = -speedX;				
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow)) 
		{
			speed = 0;				
		}

		//Movimiento con control derecho
		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			speed = speedX;				
		}
		if (Input.GetKeyUp (KeyCode.RightArrow)) 
		{
			speed = 0;				
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) // saltar
		{
			Jumping = true; //bool
			rb.AddForce (new Vector2 (rb.velocity.x, jumpSpeedY)); // variables para movimiento
			anim.SetInteger ("State", 3); // agregar animacion al salto por medio de la variable State
		}


		//Condicionales para botón G, cambio de animacion
		if (Input.GetKey(KeyCode.G)) 
		{
			anim.SetInteger ("State", 2);				
		}

	}

	void MovePlayer(float playerSpeed) //movimientos en x y y
	{
		Flip ();

		if (playerSpeed < 0 && !Jumping || playerSpeed > 0 && !Jumping) 
		{
			anim.SetInteger ("State", 1);		//asignacion de animacion "avanza"
		}

		if (playerSpeed == 0 && !Jumping ) 
		{
			anim.SetInteger ("State", 0);		
		}

		rb.velocity = new Vector3 (speed, rb.velocity.y, 0);
	}

	void Flip()
	{
		if (speed > 0 && !facingRight || speed < 0 && facingRight) 
		{
			facingRight = !facingRight;

			Vector3 temp = transform.localScale;  //para cambiar de sentido del sprite
			temp.x *= -1;
			transform.localScale = temp;
		}


	}	

	void OnCollisionEnter2D(Collision2D other) //parar la animación del salto al tocar la tierra
	{
		if (other.gameObject.tag == "Ground") 
		{
			Jumping = false;
			anim.SetInteger ("State", 0);
		}

	}

	public void WalkLeft () //funcion para movimiento izq y derecho que seran asociadas a los botones graficos
	{
		speed = -speedX;
	}

	public void WalkRight ()
	{
		speed = speedX;
	}

	public void Stop ()
	{
		speed = 0;
	}

	public void Jump ()
	{
		Jumping = true;
		rb.AddForce (new Vector2 (rb.velocity.x, jumpSpeedY));
		anim.SetInteger ("State", 3);
	} 

	public void Punch ()
	{
		anim.SetInteger ( "State", 2);
	} 
}

