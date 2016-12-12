using UnityEngine;
using System.Collections;


public class recievedelegates : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Delegate.ZooKeeper += ZooKeeperHandler;
		Delegate.ZooKeeperWords += ZooKeeperWordsHandler;
		Delegate.ZooKeeperRun += ZooKeeperRunHandler;
	}

	private void ZooKeeperHandler ()
	{
		print ("Im a zookeeper.");
	}

	private void ZooKeeperWordsHandler (string w)
	{
		print (w);
	}

	private void ZooKeeperRunHandler (string r)
	{
		print (r);
	}
}
