using UnityEngine;
using System.Collections;

public class ProceedureSpawn : MonoBehaviour
{
	public GameObject thingy;
	public float Minhorizontalpos = 10.0f;
	public float Maxhorizontalpos = 10.0f;
	public float Maxverticalpos = 10.0f;
	public float Minverticalpos = 10.0f;

	public float minspawnrate = 10.0f; 
	public float Maxspawnrate = 1.0f;


	// Use this for initialization
	void Start () 
	{
	
		Invoke("SpawnNow", Random.Range(minspawnrate, Maxspawnrate)); 
	
	}
	


	void Update() 
	{
		Instantiate(thingy,transform.position + new Vector3(Random.Range(Minhorizontalpos,Maxhorizontalpos),Random.Range(Minverticalpos,Maxverticalpos)), Quaternion.identity);
	
		Invoke("SpawnNow", Random.Range(minspawnrate, Maxspawnrate)); 
	
	}

}
