using UnityEngine;
using System.Collections;

public class ControladorPersonaje : MonoBehaviour {

	public float fuerzaSalto = 100f;


	// Use this for initialization
	void Start () {
	
	} 
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * fuerzaSalto);
		}


	}
}
