using UnityEngine;
using System.Collections;

public class PlaySoundOnInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 	
	
	
	{
	

		//Touch move left and right
		

		if(Input.GetAxis("Horizontal")!=0.0f || PseudoInput.Instance.leftpressed || PseudoInput.Instance.rightpressed)
			
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
