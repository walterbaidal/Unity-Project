using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzar : MonoBehaviour {

	public float impulsoAdelante = 7.3f;
	public float impulsoArriba = 15f;
	void Start () 
	{
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0f, impulsoArriba, impulsoAdelante), ForceMode.Impulse);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
