using UnityEngine;
using System.Collections;

public class ForeachLoopOne : MonoBehaviour {

	// Use this for initialization
	void Start () {
		{
			string[] strings = new string[3];

			strings[0] = "One Fish";
			strings[1] = "Two Fish";
			strings[2] = "Red Fish...";

			foreach(string item in strings)
			{
				print (item);
			}
		}
	}
}