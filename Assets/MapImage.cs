using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MapImage : MonoBehaviour {

	public Scrollbar sb;
	public Sprite s1;
	public Sprite s2;
	public Sprite s3;
	Image i;

	// Use this for initialization
	void Start () 
	{
		i = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(sb.value >= .25f && sb.value <= .75f)
		{
			i.sprite = s2;
		}
		else if(sb.value < .25f)
		{
			i.sprite = s1;
		}
		else if(sb.value > .75f)
		{
			i.sprite = s3;
		}
	}
}
