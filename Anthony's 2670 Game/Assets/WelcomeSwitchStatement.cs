using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WelcomeSwitchStatement : MonoBehaviour {

	public int welcome;
	//private bool wellhellotherevar = true;

    private List<string> dialogue;

	// Use this for initialization
	void Start () {

        dialogue = new List<string>()
        {
            "Just follow me and have fun!",
            "We have a special treat for you today so let's not waste time!",
            "Welcome to Justin's zoo!",
            "Well hello there!" 
        };

		welcome = 4;
		Intro();
	}

	public void Intro () {
		switch (welcome)
		{
		case 4:
			StartCoroutine (Wait ());
			print (ReturnDialogue (welcome));
			break;
			//goto case 2;
		case 3:
			StartCoroutine (Wait ());
			print (ReturnDialogue(welcome));
			break;
			//goto case 1;
		case 2:
			StartCoroutine (Wait ());
			print (ReturnDialogue(welcome));

			break;//goto default;
		case 1:
			print(ReturnDialogue (welcome));
			break;
		}
	}
    
    string ReturnDialogue (int num)
    {
        return dialogue[num-1];
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