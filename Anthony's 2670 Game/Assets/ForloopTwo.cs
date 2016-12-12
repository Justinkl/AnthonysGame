using UnityEngine;
using System.Collections;

public class ForloopTwo : MonoBehaviour {

	int cirucsAnimals = 2;


	// Use this for initialization
	void Start () {
		{
			for(int i = 0; i < cirucsAnimals; i++)
			{
				print("Releasing the circus Animals: " + i);
			}
		}

	}
}