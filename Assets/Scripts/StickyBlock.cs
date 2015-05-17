using UnityEngine;
using System.Collections;

public class StickyBlock : MonoBehaviour {

	[HideInInspector]
	public bool isSticky;

	[HideInInspector]
	public Color newColor;

	Color oldColor;

	public Color[] ColorOptions;
	public float timer;
	float startTime;

	// Use this for initialization
	void Start () 
	{
		timer *= 60;
		startTime = timer;
		oldColor = GetComponent<Renderer>().material.color;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isSticky)
		{
			timer--;
			if(timer > 0)
			{
				if(newColor != null)
				{

					GetComponent<Renderer>().material.color = newColor;
				}
			}
			else
			{
				isSticky = false;
				timer = startTime;
			}
		}
		else
		{

			GetComponent<Renderer>().material.color = oldColor;
		}
	}

	void OnTriggerEnter(Collider c)
	{
		if (isSticky)
		{
			if(c.gameObject.tag.Equals("Player"))
			{
				Debug.Log ("Stuck");
				timer = startTime;
			}

		}

		else if(!isSticky)
		{
			if(c.gameObject.tag == "Bomb1")
			{
				GetComponent<StickyBlock>().isSticky = true;
				newColor = ColorOptions[0];
				Destroy(c.gameObject);
			}
			else if(c.gameObject.tag == "Bomb2")
			{
				GetComponent<StickyBlock>().isSticky = true;
				newColor = ColorOptions[1];
				Destroy(c.gameObject);
			}
			else if(c.gameObject.tag == "Bomb3")
			{
				GetComponent<StickyBlock>().isSticky = true;
				newColor = ColorOptions[2];
				Destroy(c.gameObject);
			}
			else if(c.gameObject.tag == "Bomb4")
			{
				GetComponent<StickyBlock>().isSticky = true;
				newColor = ColorOptions[3];
				Destroy(c.gameObject);
			}
		}
	}
}
