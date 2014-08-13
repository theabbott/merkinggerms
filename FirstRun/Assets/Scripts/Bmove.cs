using UnityEngine;
using System.Collections;

public class Bmove : MonoBehaviour {
	public float Bspeed = 1.0f; 
	public Vector3 direction = Vector3.forward;
	
	// Use this for initialization
	void Start () 
	{
		transform.position = new Vector3 (0, 2, -40);	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.rotation*(direction*Bspeed*Time.deltaTime);
	}
}
