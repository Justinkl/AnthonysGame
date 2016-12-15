using UnityEngine;
using System.Collections;

public class InstructionSwitch : MonoBehaviour {


	public int instructions;
	// Use this for initialization
	void Start () {
		instructions = 5;
		Narrator ();
	
	}
	
	// Update is called once per frame
	public void Narrator () {
		switch (instructions) {
		case 5:
			StartCoroutine (Pause ());
			print ("Looks like the zookeeper just quit.");
			break;
		case 4:
			StartCoroutine (Pause ());
			print ("Guess he just couldn't take the noise.");
			break;
		case 3:
			StartCoroutine (Pause ());
			print ("Each of the animals have a noise they make...");
			break;
		case 2:
			StartCoroutine (Pause ());
			print ("Try clicking to see what the animals say.");
			break;
		case 1:
			StartCoroutine (Pause ());
			print ("Don't get into to trouble now, okay?");
			break;
		}
	}

	IEnumerator Pause ()
	{
		yield return new WaitForSeconds (4);
		instructions--;
		Narrator ();
	}
}
