using UnityEngine;
using System.Collections;

public class PLaySoundOnTrigger : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter () 
	{
	
		audio.Play();
	}
	

}
