using UnityEngine;
using System.Collections;

public class FirstWhileLoop : MonoBehaviour {

	int PolarBears = 25;

	// Use this for initialization
	void Start () {
	
		while (PolarBears > 0) 
		{
			Debug.Log ("We don't have many polar bears.");
			PolarBears--;
		}
	}

}
