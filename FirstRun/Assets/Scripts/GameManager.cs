using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	
	private bool gameover = false;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
		
		
	{
		if(GameObject.FindGameObjectWithTag ("Player") == null)
		   {
			
			
			gameover = true; 
			
		}
		
		if (gameover)
		{
			
			if(Input.anyKeyDown)
			{
				Application.LoadLevel(Application.loadedLevel);
			}
			
			
		}
		
		
		
		}
		
		void OnGUI () 
		
		
		{
			if (gameover == true)
				GUILayout.Label ("ITS OVER! PRESS ENTER TO TRY AGAIN");
		}
		
		
		}

