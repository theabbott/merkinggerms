using UnityEngine;
using System.Collections;

public class Animatedtexture : MonoBehaviour {

	public Vector2 speed = Vector2.up; 
	public Vector2 oldspeed; 
	//public Coroutine SpeedDown;	

	
	
	
	// Use this for initialization
	void Start () 
	{

		oldspeed = speed;	
		//StartCoroutine ("SpeedUp");
		StartCoroutine ("SpeedDown");

		 
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		renderer.material.mainTextureOffset += speed * Time.deltaTime ;
		//if(Input.GetButtonDown ("Vertical"))
		if (speed.y>=0)
			speed.y += 0.1f*Input.GetAxis("Vertical"); 
		//GameObject.Find("CyclinderParent.prefab").GetComponent<SphereMove>().sspeed+= 0.1f*Input.GetAxis("Vertical");

		if (speed.y < 0)
						speed.y = 1f;
		//GameObject.Find("CyclinderParent.prefab").GetComponent<SphereMove> ().sspeed = 0.1f;
		 //return;

		if(Input.GetButtonUp("Vertical"))

			StartCoroutine ("SpeedDown");
		Invoke ("SpeedDown",1);
			
				
	}
	IEnumerator SpeedDown() {

		print ("startedcooutine");
		while (speed.y>oldspeed.y)
			speed.y -= 1f;			
		yield return null;
		}



}
