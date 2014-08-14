using UnityEngine;
using System.Collections;

public class LoadLevelOnTouched : MonoBehaviour 
{

	public string levelname = "Level1";




	// Use this for initialization
	void Touched () 
	
	
	{
	
		Application.LoadLevel (levelname); 

	}
	
	// Update is called once per frame
	void Update () 
	
	{


		if(Input.touchCount>=2)
			Application.LoadLevel (levelname); 
			//Application.LoadLevel (levelname);
	
	}
}
