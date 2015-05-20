using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Jetpack : MonoBehaviour {

	public bool hasJetpack = false;
	public int ID = -1;
	public bool secondJump = false;
	bool m_Jump = false;

	// Use this for initialization
	void Start () 
	{
		ID = GetComponent<LocalUserControl> ().PLAYERID;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(hasJetpack)
		{
			switch(ID)
			{
				case 1:
					m_Jump = CrossPlatformInputManager.GetButtonDown("p1Jump");
					break;
				case 2:
					m_Jump = CrossPlatformInputManager.GetButtonDown("p2Jump");
					break;
				case 3:
					m_Jump = CrossPlatformInputManager.GetButtonDown("p3Jump");
					break;
				case 4:
					m_Jump = CrossPlatformInputManager.GetButtonDown("p4Jump");
					break;
			}
		}



		if(m_Jump && !secondJump)
		{


		}

		m_Jump = false;
	}
}
