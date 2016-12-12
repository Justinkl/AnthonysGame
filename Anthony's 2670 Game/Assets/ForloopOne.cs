using UnityEngine;
using System.Collections;

public class ForloopOne : MonoBehaviour 
{
	int wildAnimals = 3;


		void Start ()
	{
		for(int i = 0; i < wildAnimals; i++)
		{
			Debug.Log("Releasing the wild Animals: " + i);
		}
	}
}
