using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marcador : MonoBehaviour {


	public int puntuacion = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape))
			Application.Quit (); 
	}

	void OnTriggerExit (Collider collider)
	{
		GameObject obj = collider.gameObject;
		puntuacion++;
	}

	void OnGUI()
	{
		string texto = "Puntuación: " + puntuacion;
		GUI.TextField (new Rect (500, 10, 200, 20), texto);
		GUI.TextField (new Rect (10, 35, 300, 20), "Lanzamiento seguro: C");
		GUI.TextField (new Rect (10, 55, 300, 20), "Lanzamiento aleatorio: Barra espaciadora");
	}
}
