﻿using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.ThirdPerson;

public class LocalUserControl : MonoBehaviour {
	
	public int PLAYERID = 1;
	private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
	private Transform m_Cam;                  // A reference to the main camera in the scenes transform
	private Vector3 m_CamForward;             // The current forward direction of the camera
	private Vector3 m_Move;
	private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
	[HideInInspector]
	public bool Dead = false;
	int dd = 60;
	public Camera gameCam;
	[HideInInspector]
	public Camera cctvCam;
	bool stuck = false;
	int stuckT = 60 * 3;
	int stuckTR = 60 * 3;
	public bool hasJetpack = false;
	public GameObject myJetpack;
	int jT = 240;
	int jTR= 240;

	void Start()
	{
		stuckTR = stuckT;
		myJetpack.active = false;
		// get the transform of the main camera
		if (Camera.main != null)
		{
			m_Cam = Camera.main.transform;
		}
		else
		{
			Debug.LogWarning(
				"Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.");
			// we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
		}
		
		cctvCam = GameObject.Find ("CctvCamera").GetComponent<Camera> ();
		// get the third person character ( this should never be null due to require component )
		m_Character = GetComponent<ThirdPersonCharacter>();
	}
	
	
	void Update()
	{
		if(Dead)
		{
			dd--;
			
			if(dd <= 0)
			{
				gameCam.enabled = false;
				cctvCam.enabled = true;
				GameObject.Destroy(this.gameObject);
			}
		}
		else
		{
			if (!m_Jump)
			{
				switch(PLAYERID)
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
		}
	}       

	public void Stuck()
	{
		stuck = true;
	}
	
	// Fixed update is called in sync with physics
	void FixedUpdate()
	{
		bool jetJump = false;

		if(hasJetpack)
		{
			switch(PLAYERID)
			{
				case 1:
					jetJump = CrossPlatformInputManager.GetButton("p1Jump");
					break;
				case 2:
					jetJump = CrossPlatformInputManager.GetButton("p2Jump");
					break;
				case 3:
					jetJump = CrossPlatformInputManager.GetButton("p3Jump");
					break;
				case 4:
					jetJump = CrossPlatformInputManager.GetButton("p4Jump");
					break;
			}

			if(jetJump)
			{
				Debug.Log(jetJump.ToString());
				Vector3 jetForce = Vector3.up;
				m_Character.Move(jetForce, false, true);

				jT -- ;

				if(jT <= 0)
				{
					jT = jTR;
					hasJetpack = false;
				}
			}
		}

		if (!stuck) 
		{
			switch (PLAYERID) {
			case 1:
			// read inputs
				float h = CrossPlatformInputManager.GetAxis ("p1Horizontal");
				float v = CrossPlatformInputManager.GetAxis ("p1Vertical");
				bool crouch = Input.GetButton ("p1Crouch");
			
			// calculate move direction to pass to character
				if (m_Cam != null) {
					// calculate camera relative direction to move:
					m_CamForward = Vector3.Scale (m_Cam.forward, new Vector3 (1, 0, 1)).normalized;
					m_Move = v * m_CamForward + h * m_Cam.right;
				} else {
					// we use world-relative directions in the case of no main camera
					m_Move = v * Vector3.forward + h * Vector3.right;
				}
			#if !MOBILE_INPUT
			// walk speed multiplier
				if (Input.GetKey (KeyCode.LeftShift))
					m_Move *= 1.5f;
			#endif
			
				Debug.Log(m_Move.ToString() + "\n" + crouch.ToString() + "\n" +	 m_Jump.ToString());
			// pass all parameters to the character control script
				m_Character.Move (m_Move, crouch, m_Jump);
				m_Jump = false;

				break;
			case 2:
			// read inputs
				h = CrossPlatformInputManager.GetAxis ("p2Horizontal");
				v = CrossPlatformInputManager.GetAxis ("p2Vertical");
				crouch = Input.GetButton ("p2Crouch");
			
			// calculate move direction to pass to character
				if (m_Cam != null) {
					// calculate camera relative direction to move:
					m_CamForward = Vector3.Scale (m_Cam.forward, new Vector3 (1, 0, 1)).normalized;
					m_Move = v * m_CamForward + h * m_Cam.right;
				} else {
					// we use world-relative directions in the case of no main camera
					m_Move = v * Vector3.forward + h * Vector3.right;
				}
			#if !MOBILE_INPUT
			// walk speed multiplier
				if (Input.GetKey (KeyCode.LeftShift))
					m_Move *= 1.5f;
			#endif
			
			// pass all parameters to the character control script
				m_Character.Move (m_Move, crouch, m_Jump);
				m_Jump = false;
				break;
			case 3:
			// read inputs
				h = CrossPlatformInputManager.GetAxis ("p3Horizontal");
				v = CrossPlatformInputManager.GetAxis ("p3Vertical");
				crouch = Input.GetButton ("p3Crouch");
			
			// calculate move direction to pass to character
				if (m_Cam != null) {
					// calculate camera relative direction to move:
					m_CamForward = Vector3.Scale (m_Cam.forward, new Vector3 (1, 0, 1)).normalized;
					m_Move = v * m_CamForward + h * m_Cam.right;
				} else {
					// we use world-relative directions in the case of no main camera
					m_Move = v * Vector3.forward + h * Vector3.right;
				}
			#if !MOBILE_INPUT
			// walk speed multiplier
				if (Input.GetKey (KeyCode.LeftShift))
					m_Move *= 1.5f;
			#endif
			
			// pass all parameters to the character control script
				m_Character.Move (m_Move, crouch, m_Jump);
				m_Jump = false;
				break;
			case 4:
			// read inputs
				h = CrossPlatformInputManager.GetAxis ("p4Horizontal");
				v = CrossPlatformInputManager.GetAxis ("p4Vertical");
				crouch = Input.GetButton ("p4Crouch");
			
			// calculate move direction to pass to character
				if (m_Cam != null) {
					// calculate camera relative direction to move:
					m_CamForward = Vector3.Scale (m_Cam.forward, new Vector3 (1, 0, 1)).normalized;
					m_Move = v * m_CamForward + h * m_Cam.right;
				} else {
					// we use world-relative directions in the case of no main camera
					m_Move = v * Vector3.forward + h * Vector3.right;
				}
			#if !MOBILE_INPUT
			// walk speed multiplier
				if (Input.GetKey (KeyCode.LeftShift))
					m_Move *= 1.5f;
			#endif
			
			// pass all parameters to the character control script
				m_Character.Move (m_Move, crouch, m_Jump);
				m_Jump = false;
				break;
			}
		}
		else
		{
			m_Character.Move(Vector3.zero, true, false);

			stuckT--;

			if(stuckT <= 0)
			{
				stuckT = stuckTR;
				stuck = false;
			}


		}
	}
}
