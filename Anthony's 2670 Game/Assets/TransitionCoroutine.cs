using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TransitionCoroutine : MonoBehaviour {


	// Use this for initialization
	void Start () {
		StartCoroutine (Countdown());
	}

	private IEnumerator Countdown ()
	{
		yield return new WaitForSeconds (12);
		SceneManager.LoadScene (1);
	}

    void OtherThing()
    {
        //These two statements are exactly the same
        ThisThing().SetActive(false);
        gameObject.SetActive(false);
    }

    GameObject ThisThing()
    {
        return gameObject;
    }
}
