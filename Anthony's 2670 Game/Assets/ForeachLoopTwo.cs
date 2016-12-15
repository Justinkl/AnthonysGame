using UnityEngine;
using System.Collections;

public class ForeachLoopTwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		{
			string[] strings = new string[4];

			strings[0] = "If it hasn't been noticed already...";
			strings[1] = "All of these scripts are...";
			strings[2] = "Probably useless when it comes...";
			strings[3] = "The actual game.";

			foreach(string item in strings)
			{
				print (item);
			}
		}
	}
}