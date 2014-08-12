using UnityEngine;
using System.Collections;

public class MoveGamespeed : MonoBehaviour {

	public Vector3 direction = Vector3.forward;
	public float OGSpeed; 
	// Use this for initialization
	void Start () 
	{
	
		OGSpeed = GameManager.instance.gamespeed;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//transform.position += Vector3.right;
		transform.position += transform.rotation*(direction.normalized*GameManager.instance.gamespeed*Time.deltaTime);
		if (GameManager.instance.gamespeed>=0)
			GameManager.instance.gamespeed += 0.1f*Input.GetAxis("Vertical"); 
		
		if (GameManager.instance.gamespeed < 0)
			GameManager.instance.gamespeed = OGSpeed;
		
		if(Input.GetButtonUp("Vertical"))
			
			if (GameManager.instance.gamespeed>OGSpeed)
				GameManager.instance.gamespeed -= 1.0f;



		//print (transform.position);


	}


}
