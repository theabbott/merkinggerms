using UnityEngine;
using System.Collections;

public class DetectTouchNClicks : MonoBehaviour {




	// Use this for initialization
	void Start () 
	{
	
	
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	//detect ojects clicked by mouse
		if(Input.GetMouseButton(0))
		{
		
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit))
			{
			
				//Debug.Log("Object Name :" + hit.collider.name, hit.collider.gameObject); 
				hit.collider.SendMessage("Touched" , SendMessageOptions.DontRequireReceiver);
			
			}
		
		}


		//detect objects by touch

		if(Input.touchCount>0)
		{
		
			foreach (Touch touche in Input.touches)
			         {
			
				Ray ray = Camera.main.ScreenPointToRay((Vector3)touche.position);
				
				RaycastHit hit;
				if(Physics.Raycast(ray, out hit))
				{
					
					//Debug.Log("Object Name :" + hit.collider.name, hit.collider.gameObject); 
					hit.collider.SendMessage("Touched" , SendMessageOptions.DontRequireReceiver);			
					}

		
		
		
		}
	}
}

}
