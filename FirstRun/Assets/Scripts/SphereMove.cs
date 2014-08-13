using UnityEngine;
using System.Collections;

public class SphereMove : MonoBehaviour {

	public float sspeed = 1.0f; 
	public float OGSpeed = 1.0f;
	//public GameObject Cylinder;
	// Use this for initialization
	void Start () 
	{
		OGSpeed = sspeed;
	}
	
	// Update is called once per frame
	void Update () 
	{
	

		transform.position += Vector3.back*Time.deltaTime*sspeed;
		if (sspeed>=0)
			sspeed += 0.1f*Input.GetAxis("Vertical"); 

		if (sspeed < 0)
						sspeed = OGSpeed;
		 
		if(Input.GetButtonUp("Vertical"))

			if (sspeed>OGSpeed)
				sspeed -= 1f;			


			//StartCoroutine ("SSpeedDown");
		//Invoke ("SSpeedDown",1);




	
	}


	//IEnumerator SSpeedDown() {
		
		//print ("startedcooutine For Cyclinders");

	//}



}

