using UnityEngine;
using System.Collections;

public class ButtonScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoToLocal()
	{
		Debug.Log ("Entered Method Block.");
		Application.LoadLevel ("localMenu");
	}
}
