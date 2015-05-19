using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowWinner : MonoBehaviour {

	GameObject Winner;
	public GameObject[] WinnerOptions;
	Text t;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Winner = GameObject.FindGameObjectWithTag ("Player");
		if(this.isActiveAndEnabled)
		{
			if(Winner.name == "LocalCompetitor (P1)")
			{
				WinnerOptions[0].SetActive(true);
				WinnerOptions[1].SetActive(false);
				WinnerOptions[2].SetActive(false);
				WinnerOptions[3].SetActive(false);
			}
			else if(Winner.name == "LocalCompetitor (P2)")
			{
				WinnerOptions[0].SetActive(false);
				WinnerOptions[1].SetActive(true);
				WinnerOptions[2].SetActive(false);
				WinnerOptions[3].SetActive(false);
			}
			else if(Winner.name == "LocalCompetitor (P3)")
			{
				WinnerOptions[0].SetActive(false);
				WinnerOptions[1].SetActive(false);
				WinnerOptions[2].SetActive(true);
				WinnerOptions[3].SetActive(false);
			}
			else if(Winner.name == "LocalCompetitor (P4)")
			{
				WinnerOptions[0].SetActive(false);
				WinnerOptions[1].SetActive(false);
				WinnerOptions[2].SetActive(false);
				WinnerOptions[3].SetActive(true);
			}
		}
	}
}
