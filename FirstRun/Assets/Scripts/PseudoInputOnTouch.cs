using UnityEngine;
using System.Collections;

public class PseudoInputOnTouch : MonoBehaviour {

	// Use this for initialization
	public enum PseudoInputDirection {left, right} 
	public PseudoInputDirection direction; 
	void Touched () 
	
	{
			if(direction==PseudoInputDirection.left)
		{

			PseudoInput.Instance.leftpressed = true;

		}

		if(direction==PseudoInputDirection.right)
			
		{
			PseudoInput.Instance.rightpressed = true;
		}
	}
	

}
