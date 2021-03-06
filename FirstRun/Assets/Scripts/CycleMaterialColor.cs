﻿using UnityEngine;
using System.Collections;

public class CycleMaterialColor : MonoBehaviour 
{

	public float cycleTime = 30.0f;
	public float saturation = 1.0f;
	public float brightness = 1.0f;

	// Use this for initialization
	void Start () 
	{
	
		StartCoroutine("CycleColors");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		 


	}

	IEnumerator CycleColors () 
	{
		
		float t = 1.0f;
		float hue = 0.0f;
		while (t<cycleTime) 
		{

			hue = Mathf.Lerp(0.0f,1.0f,t/cycleTime);
			renderer.material.color = new HSBColor(hue,saturation,brightness).ToColor();
			t += Time.deltaTime;
			yield return null;
		}

			

		
		hue=1.0f;

		StartCoroutine("CycleColors");
		
		
	}


}
