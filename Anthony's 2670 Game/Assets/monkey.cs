﻿using UnityEngine;
using System.Collections;

public class monkey : animal {

	public override void Start (){
		print ("Me want banana!");
		Alive();
	}
    void OnMouseDown()
    {
        print("Me want banana!");
    }
}
