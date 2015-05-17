using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	Text t;
	int i;
	public int StartTimer;
	// Use this for initialization
	void Start () {
		t = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	 void Update () {
		Debug.Log (i / 60);
		if (i / 60 >= StartTimer) 
		{

			t.text = "TIME: " + (i / 60 - StartTimer).ToString ();
		}
	}

	void FixedUpdate()
	{
		i++;
	}
}
