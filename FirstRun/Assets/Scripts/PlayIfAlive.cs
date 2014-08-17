using UnityEngine;
using System.Collections;

public class PlayIfAlive
: MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 	
		
		
	{
		
		
		//Touch move left and right
		
		
		if(GameObject.FindGameObjectWithTag("Player") != null)
			
		{
			if(!audio.isPlaying)
			{
				audio.Play();
			}
		}
		
		
		else
			
		{
			audio.Stop();
			
		}
		
		
		
		
	}
}
