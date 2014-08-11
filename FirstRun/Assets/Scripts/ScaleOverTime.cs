using UnityEngine;
using System.Collections;

public class ScaleOverTime : MonoBehaviour 
{

	public Vector3 finalscale = Vector3.zero; 
	private Vector3 initialscale;
	public float time = 1.0f;


	// Use this for initialization
	void Start () 
	{
	
		initialscale = transform.localScale;
		StartCoroutine ("Scale");


	}
	
	// Function coroutine to scale obstacles.
	IEnumerator Scale () 
	{
	
		float t = 0.0f;
		while (t<= time) 
		{	
			transform.localScale=Vector3.Lerp(initialscale,finalscale,t/time);
			t += Time.deltaTime;
			yield return null;
		}

		transform.localScale = finalscale;

	
	}
}
