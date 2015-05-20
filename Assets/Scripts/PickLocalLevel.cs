using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PickLocalLevel : MonoBehaviour {

	public Scrollbar level;
	public Scrollbar numPlayers;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetFloat ("Level", level.value);
		PlayerPrefs.SetFloat ("Players", numPlayers.value);
		PlayerPrefs.Save ();

	}

	public void SelectLevel()
	{
		if(PlayerPrefs.GetFloat("Level") == 0)
		{
			Application.LoadLevel("LOCAL_Square");
			Debug.Log(PlayerPrefs.GetFloat("Level") + "," + PlayerPrefs.GetFloat("Players"));

		}
		else if(PlayerPrefs.GetFloat("Level") == .5f)
		{
			Application.LoadLevel("LOCAL_Circle");
			Debug.Log(PlayerPrefs.GetFloat("Level") + "," + PlayerPrefs.GetFloat("Players"));
			
		}
		else if(PlayerPrefs.GetFloat("Level") == 1f)
		{
			Application.LoadLevel("LOCAL_Legos");
			Debug.Log(PlayerPrefs.GetFloat("Level") + "," + PlayerPrefs.GetFloat("Players"));
			
		}
	}
}
