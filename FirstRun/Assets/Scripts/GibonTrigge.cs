using UnityEngine;
using System.Collections;

public class GibonTrigge : MonoBehaviour {

	public GameObject gib;


	void OnTriggerEnter()
	{

		//Debug.Log ("We've got  this shit");
		Instantiate (gib, transform.position, Quaternion.identity);
		Destroy(gameObject);

	}



	

}
