using UnityEngine;
using System.Collections;

public class Displayhighscore : MonoBehaviour {

	private string lable; 

	// Use this for initialization
	void Start () 
	{
	
		TextMesh textMesh = GetComponent<TextMesh>();
			lable = textMesh.text;
		textMesh.text = lable + PlayerPrefs.GetInt("HighestScore");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
