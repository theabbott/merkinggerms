using UnityEngine;
using System.Collections;

public class Afterburner : MonoBehaviour {

	// Use this for initialization
	void Start () 
	
	{
	
		particleSystem.enableEmission = false;


	}
	
	// Update is called once per frame
	void Update () 
	
	{
	
		if(Input.GetButtonDown("Vertical"))

			particleSystem.enableEmission = true;
		if(Input.GetButtonUp("Vertical"))

			particleSystem.enableEmission = false;
	}
}
