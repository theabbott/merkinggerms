using UnityEngine;
using System.Collections;

public class DisplayLastscore : MonoBehaviour {

	private string lable; 

	// Use this for initialization
	void Start () 
	{
	
		TextMesh textMesh = GetComponent<TextMesh>();
			lable = textMesh.text;
		textMesh.text = lable + GameManager._instance.previousscore;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
