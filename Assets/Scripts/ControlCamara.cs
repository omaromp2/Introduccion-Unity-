using UnityEngine;
using System.Collections;

public class ControlCamara : MonoBehaviour {
	public GameObject Jugador; 
	private Vector3 offset; 
	// Use this for initialization
	void Start () 
	{
		offset = transform.position;	
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.position = Jugador.transform.position + offset; 	
	}
}
