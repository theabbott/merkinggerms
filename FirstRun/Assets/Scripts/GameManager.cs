using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	public static GameManager _instance;


	public static GameManager Instance
	{
		get
		{

			if(_instance != null)
			{
			return _instance;
			}

			else
			{
				GameObject gameManager = new GameObject("GameManager");
				_instance = gameManager.AddComponent<GameManager>();
				return _instance;
				
			}
	}
	}
	public string titlescreenname = "titleer"; 
	private bool hasSaved = false;
	private static float highscore = 0.0f; 
	public float pointsperunittravlled = 1.0f; 
	private float score = 0.0f; 
	private bool gameover = false;
	public float gamespeed =10f;

	[HideInInspector]
	public int previousscore=0; 


	// Use this for initialization
	void Start () 
	{
			//if(_instance != this)
			


			if(_instance==null)
		{
			_instance = this;

		}

		else
		{
		
	   Destroy(gameObject);
		
		}

		LoadHighScore();
		DontDestroyOnLoad(gameObject);
	}

	
	// Update is called once per frame
	void Update () 
		
		
	{



		if(Application.loadedLevelName != titlescreenname)
		{
		if(!gameover)
		{
		score+=pointsperunittravlled*gamespeed*Time.deltaTime;
		}

			if (score>highscore)
		{
			highscore = score;
		}
		if(GameObject.FindGameObjectWithTag ("Player") == null)
		   {
			
			
			gameover = true; 
			
		}
		
		if (gameover)
		{
			
			if(Input.anyKeyDown)
			{
				Application.LoadLevel(titlescreenname);
			}
			
		if(!hasSaved)
			{
				previousscore=(int)score; 
				SaveHighScore();
				hasSaved = true; 


			}



		}
		
		}
		
		else
		{
			//Reset stuff for next game
			ResetGame();

		}
		
		}
		
		void ResetGame()
	{
		score = 0.0f;
		gameover=false;
		hasSaved=false;


	}




	void OnGUI () 


		 

	{

		if(Application.loadedLevelName != titlescreenname)
		{

		int currentscore = (int)score;
		int currenthighscore = (int)highscore;

		GUILayout.Label("Score: " + currentscore.ToString());
		GUILayout.Label("HighScore: " + currenthighscore.ToString());
		
		

		

		if (gameover == true)
			GUILayout.Label ("ITS OVER! PRESS ENTER TO QUIT TO TITLESCREEN");

		
		
	}
	}
	void SaveHighScore()
	{

		PlayerPrefs.SetInt("HighestScore", (int)highscore);
		PlayerPrefs.Save();



	}


	void LoadHighScore()
	{
	
		highscore = PlayerPrefs.GetInt("HighestScore");
	
	}


}
