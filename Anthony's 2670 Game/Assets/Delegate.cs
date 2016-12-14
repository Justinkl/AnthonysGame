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
        if (ZooKeeper != null)
		ZooKeeper ();
        if (ZooKeeperWords != null)
		ZooKeeperWords ("These animals are too noisy!");
        if (ZooKeeperComplain != null)
		ZooKeeperComplain ("They've gone absolutely wild!");
        if (ZooKeeperRun != null)
		ZooKeeperRun ("I'm running away!");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
