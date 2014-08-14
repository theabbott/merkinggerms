using UnityEngine;
using System.Collections;

public class PseudoInput : MonoBehaviour {

	public static PseudoInput Instance
	{
		get
		{
			
			if(_instance != null)
			{
				return _instance;
			}
			
			else
			{
				GameObject gameManager = new GameObject("PseudoInput");
				_instance = gameManager.AddComponent<PseudoInput>();
				return _instance;
				
			}
		}
	}
	private static PseudoInput _instance; 

	public bool leftpressed = false; 
	public bool rightpressed = false; 

	// Use this for initialization
	void Start () 
	
	{
	
	}
	
	// Update is called once per frame
	void LateUpdate () 
	
	
	{
		leftpressed = false; 
	    rightpressed = false; 



	}
}
