using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarRandom : MonoBehaviour {

	public float impulsoArriba = 15f;


	void Start () 
	{
		float impulsoAdelanteRandom = Random.Range(6.5f, 9.0f);
		float impulsoLateralRandom = Random.Range(-1.5f, 1.5f);
		GetComponent<Rigidbody> ().AddForce (new Vector3 (impulsoLateralRandom, impulsoArriba, impulsoAdelanteRandom), ForceMode.Impulse);
	}

	// Update is called once per frame
	void Update () {

	}
}
