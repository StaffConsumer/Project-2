using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	Text t;

	// Use this for initialization
	void Start () 
	{
		t = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Spawner.Deleted)
		{
			t.text = "";
		}
		else if(Spawner.GameStarted)
		{
			t.text = "GO!";
			t.fontSize = 100;
		}
		else
		{
			int Display = Spawner.StartTimer / 60 + 1;
			
			int nextSecond = Spawner.StartTimer % 60;
			float txtSize = ((float)nextSecond / 60);
			txtSize *= 100;
			
			t.fontSize = (int)txtSize;
			t.text = Display.ToString ();
		}
	}
}
