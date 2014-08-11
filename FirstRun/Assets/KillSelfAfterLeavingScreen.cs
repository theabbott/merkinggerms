using UnityEngine;
using System.Collections;

public class KillSelfAfterLeavingScreen : MonoBehaviour {

	 void OnBecameInvisible() 

	{

		Destroy(gameObject);

	}
}