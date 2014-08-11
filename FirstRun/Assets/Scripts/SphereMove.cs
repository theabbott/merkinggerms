using UnityEngine;
using System.Collections;

public class SphereMove : MonoBehaviour {

	public float sspeed = 1.0f; 

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	

		transform.position += Vector3.back*Time.deltaTime*sspeed;



	}
}
