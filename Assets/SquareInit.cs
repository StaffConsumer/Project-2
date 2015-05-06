using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SquareInit : MonoBehaviour {

	Image i;
	float f = 0;

	// Use this for initialization
	void Start () {
		i = GetComponent<Image> ();
	}

	// Update is called once per frame
	void Update () 
	{
		if (f < 1)
			f += .01f;

		i.fillAmount = f;
	}
}
