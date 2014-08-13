using UnityEngine;
using System.Collections;

public class Doesomething : MonoBehaviour 
{
	public float speed =1.0f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		// this moves our object left or right via the keys horizontal
		transform.position += Vector3.left*Input.GetAxis("Horizontal")*speed*Time.deltaTime;



		//print (transform.position);
	
	}
}
