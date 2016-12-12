using UnityEngine;
using System.Collections;
using System;

public class Delegate : MonoBehaviour {

	public static Action ZooKeeper;

	public static Action<string> ZooKeeperWords;

	public static Action<string> ZooKeeperRun;

	// Use this for initialization
	void Start () {
		ZooKeeper ();
		ZooKeeperWords ("words");
		ZooKeeperRun ("I'm running away!");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
