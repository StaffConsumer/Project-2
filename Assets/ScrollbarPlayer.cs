using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScrollbarPlayer : MonoBehaviour {

	public Text change;
	Scrollbar sb;

	// Use this for initialization
	void Start () {
		sb = this.GetComponent<Scrollbar> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(sb.value >= .25f && sb.value <= .75f)
		{
			change.text = "3";
		}
		else if(sb.value < .25f)
		{
			change.text = "2";
		}
		else if(sb.value > .75f)
		{
			change.text = "4";
		}
	}
}
