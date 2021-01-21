using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirar : MonoBehaviour {


	public GameObject Pelota;
	public GameObject PelotaRandom;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		GameObject cubo;
		GameObject cuboRandom;
		if (Input.GetKeyDown (KeyCode.C)) {
			cubo = Instantiate (Pelota, transform.position, transform.rotation) as GameObject;
			Destroy (cubo, 7f);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			cuboRandom = Instantiate (PelotaRandom, transform.position, transform.rotation) as GameObject;
			Destroy (cuboRandom, 7f);
		}
	}
}
