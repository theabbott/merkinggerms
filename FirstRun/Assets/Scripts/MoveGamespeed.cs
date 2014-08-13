using UnityEngine;
using System.Collections;

public class MoveGamespeed : MonoBehaviour {

	public Vector3 direction = Vector3.forward;
	public float OGSpeed; 
	// Use this for initialization
	void Start () 
	{
	
		OGSpeed = GameManager._instance.gamespeed;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//transform.position += Vector3.right;
		transform.position += transform.rotation*(direction.normalized*GameManager._instance.gamespeed*Time.deltaTime);
		if (GameManager._instance.gamespeed>=0)
			GameManager._instance.gamespeed += 0.1f*Input.GetAxis("Vertical"); 
		
		if (GameManager._instance.gamespeed < 0)
			GameManager._instance.gamespeed = OGSpeed;
		
		if(Input.GetButtonUp("Vertical"))
			
			if (GameManager._instance.gamespeed>OGSpeed)
				GameManager._instance.gamespeed -= 1.0f;



		//print (transform.position);


	}


}
