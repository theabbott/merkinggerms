using UnityEngine;
using System.Collections;

public class TouchAnimateShip : MonoBehaviour {


	public float turnrate = 32.0f;
	public Vector3 OG; 
	public static Vector3 dir; 

	// Use this for initialization
	void Start () 
	
	{
	
		OG = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () 
	
	
	{

		if (PseudoInput.Instance.leftpressed == true)
			
			transform.Rotate (0, 0, -turnrate * 1);
		
		if (PseudoInput.Instance.rightpressed == true)
			
			transform.Rotate (0, 0, turnrate * 1); 


		dir.z = Input.acceleration.z;

		if(dir.z<=-0.700)
			transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, -43);
		
		
		
		if(dir.z>=0.000)
			
			transform.localPosition = new Vector3 (OG.x,OG.y,OG.z);
		GameManager._instance.gameSpeed = 15.0f;
	
	}
}
