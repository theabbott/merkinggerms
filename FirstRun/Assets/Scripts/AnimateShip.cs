using UnityEngine;
using System.Collections;

public class AnimateShip : MonoBehaviour {


		
	public float turnrate = 1.0f;
	public float og1 = 1.0f; 
	public float og2 = 1.0f;
	public float og3 = 1.0f;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	//rolls the ship left n right on player input.

		if(Input.GetButton ("Horizontal"))
					
			transform.Rotate(-Input.GetAxis("Horizontal"),0,turnrate*-Input.GetAxis("Horizontal")); 


		else

		    //transform.position= (Vector3(1.2,1.1,-47.2));
			transform.position=new Vector3 (1,1, -47);
			

		
				 
				 

	
	}
}
