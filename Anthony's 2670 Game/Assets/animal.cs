using UnityEngine;
using System.Collections;
using System;

public class animal : MonoBehaviour, ISomething {

	// Use this for initialization
	public virtual void Start () {
		print ("sound");
	
	}

	public void Alive () 
	{
		print ("That is my sound!");
	}

   public void DoSomething()
    {

    }


}
