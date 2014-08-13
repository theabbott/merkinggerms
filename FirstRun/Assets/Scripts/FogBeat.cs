using UnityEngine;
using System.Collections;

public class FogBeat : MonoBehaviour {

	public int samples = 64;
	public int frequencyChannel = 32;
	public int channel = 1;
	public FFTWindow window;
	private float ogFogDensity; 
	public float amplitutude = 10000.0f;
	// Use this for initialization
	void Start () 
	{
		ogFogDensity = RenderSettings.fogDensity;
	}
	
	// Update is called once per frame
	void Update ()
	{

		float[] data = new float [samples]; 
		AudioListener.GetSpectrumData(data,channel,window);
		Debug.Log (data [32]);
		RenderSettings.fogDensity = ogFogDensity + data[frequencyChannel]*amplitutude;
	}
}
