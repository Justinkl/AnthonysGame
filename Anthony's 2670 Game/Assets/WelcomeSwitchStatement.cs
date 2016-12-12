using UnityEngine;
using System.Collections;

public class WelcomeSwitchStatement : MonoBehaviour {

	public int welcome;
	//private bool wellhellotherevar = true;
	// Use this for initialization
	void Start () {
		welcome = 4;
		Intro();
	}

	public void Intro () {
		switch (welcome)
		{
		case 4:
			StartCoroutine (Wait ());
			print ("Well hello there!");
			break;
			//goto case 2;
		case 3:
			StartCoroutine (Wait ());
			print ("Welcome to Justin's collection!");
			break;
			//goto case 1;
		case 2:
			StartCoroutine (Wait ());
			print ("We have a special treat for you today so let's not waste time!");

			break;//goto default;
		case 1:
			print("Just follow me and have fun!");
			break;
		}
	}

	IEnumerator Wait ()
	  {
		yield return new WaitForSeconds (3);
		welcome--;
		Intro();
		//if(wellhellotherevar == true)
			//{
	  		//	wellhellotherevar = false;
	  		//}
	 //wellhellotherevar = true;

	}
}