using UnityEngine;
using System.Collections;

public class ButtonScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoToLevel(string lev)
	{
		Application.LoadLevel (lev);
	}

	public void GoToLocal()
	{
		Application.LoadLevel ("localMenu");
	}

	public void Retry()
	{
		Application.LoadLevel (Application.loadedLevelName);
	}
}
