                       using UnityEngine;
using System.Collections;

public class StaticFunction : MonoBehaviour {

    public static int elephants = 100; 
	//this is a static variable
    //make this another loop

	// Use this for initialization
	public static void Start () {
		
		while (elephants > 0) 
		{
			print ("We have plenty of elephants!");
			elephants--;
		}
	}
}
