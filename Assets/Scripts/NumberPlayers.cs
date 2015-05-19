using UnityEngine;
using System.Collections;

public class NumberPlayers : MonoBehaviour {

	public GameObject[] p;
	public GameObject[] intros;
	public GameObject[] UIs;

	float numPlayers;

	// Use this for initialization
	void Awake () {
		numPlayers = PlayerPrefs.GetFloat ("Players");
		if(numPlayers >= 0.5)
		{
			p[0].SetActive(true);
			intros[0].SetActive(true);
			UIs[0].SetActive(true);

			if(numPlayers == 1)
			{
				p[1].SetActive(true);
				intros[1].SetActive(true);
				UIs[1].SetActive(true);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
