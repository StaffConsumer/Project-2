using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	Text t;
	int i;
	public int StartTimer;
	public GameObject WC;
	public GameObject GOC;
	// Use this for initialization
	void Start () {
		t = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	 void Update () {

		if (i / 60 >= StartTimer) 
		{

			t.text = "TIME: " + (i / 60 - StartTimer).ToString ();
		}
		if(WC.activeInHierarchy || GOC.activeInHierarchy)
		{
			t.text = "";
		}

	}

	void FixedUpdate()
	{

		i++;

	}
}
