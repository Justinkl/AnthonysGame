using UnityEngine;
using System.Collections;
using System;

public class Delegate : MonoBehaviour {

	public static Action ZooKeeper;

	public static Action<string> ZooKeeperWords;

	public static Action<string> ZooKeeperComplain;

	public static Action<string> ZooKeeperRun;

	// Use this for initialization
	void Start () {
		ZooKeeper ();
		ZooKeeperWords ("These animals are too noisy!");
		ZooKeeperComplain ("They've gone absolutely wild!");
		ZooKeeperRun ("I'm running away!");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
