using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class ControlJugador : MonoBehaviour 
{
	public float speed;
	private int count; 
	public Text countText;
	public Text winText; 

	void Start()
	{
		count = 0; // inicializacion de la puntuacion
		SetCountText();
		winText.text = ""; 
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis("Horizontal");	
		float moveVertical   = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);

		rigidbody.AddForce(movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
			count = count + 1 ;
			SetCountText(); 
		}
	}

	//creamos funcion para count text 
	void SetCountText()
	{
		countText.text = "Puntuacion: " + count.ToString();
		if(count >= 7)
		{
			winText.text = "Gane el Juego! :D";
		}
	}
}
