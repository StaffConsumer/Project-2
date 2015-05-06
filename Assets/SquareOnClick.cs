using UnityEngine;
using System.Collections;

public class SquareOnClick : MonoBehaviour {

	bool loaded = false;
	// Use this for initialization
	void Start () {
	
	}
	void Update()
	{
		OnClick ();
	}
	
	void OnClick()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Application.LoadLevel ("default");
			loaded = true;
		}
	}
}
