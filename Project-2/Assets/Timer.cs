﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	Text t;
	int i;
	// Use this for initialization
	void Start () {
		t = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		t.text = "TIME: " + (i / 60).ToString ();
	}

	void FixedUpdate()
	{
		i++;
	}
}
