using UnityEngine;
using System.Collections;

public class AnimateShip : MonoBehaviour {


		
	public float turnrate = 1.0f;
	public Quaternion startrotation = Quaternion.Euler(0,3,0); 
	public Quaternion startposition = Quaternion.Euler(0,3,0);
	public Vector3 OG; 
	// Use this for initialization
	void Start () 
	{
		//var OG =  transform.localPosition;  
		 OG = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () 
	{
	//rolls the ship left n right on player input.



		if (Input.GetButton ("Horizontal"))



						transform.Rotate (-Input.GetAxis ("Horizontal"), 0, turnrate * -Input.GetAxis ("Horizontal"));		
				 

				
		 



			if (Input.GetButtonUp ("Horizontal"))
		
			//transform.rotation = Quaternion.Euler(0,3,0);
			//transform.rotation = Quaternion.Euler(0,3,0);
			
			 
		transform.rotation = Quaternion.Slerp (transform.rotation, startrotation, (Time.time * 500));
			//print("HELLOOOO") ;




		if (Input.GetButtonDown ("Vertical"))

			transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, -43);

		 

		if (Input.GetButtonUp ("Vertical"))
			
			transform.localPosition = new Vector3 (OG.x,OG.y,OG.z);			 

	
	}
}
