using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets;
using UnityStandardAssets.Characters;
using UnityStandardAssets.Cameras;
using UnityStandardAssets.Characters.ThirdPerson;

public class NetworkManager : MonoBehaviour {

	public string PlayerPrefabName = "Competitor";
	public static int totPlay = 0;
	public string RoomName = "Tile Warfare Master";
	const string VERSION = "Tile Warfare Alpha V1.0.0";
	public Transform[] SpawnPoints;

	public Camera standby;
	[HideInInspector]
	public Spawner spawn;
	// Use this for initialization
	void Start () 
	{
		PhotonNetwork.ConnectUsingSettings (VERSION);
		spawn = this.GetComponent<Spawner> ();
	}

	void OnGUI()
	{
		GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString ());
	}

	void OnJoinedLobby()
	{
		RoomOptions room = new RoomOptions (){isVisible = false, maxPlayers = 4 };
		PhotonNetwork.JoinOrCreateRoom (RoomName, room, TypedLobby.Default);
	}

	void OnJoinedRoom()
	{
		SpawnMyPlayer ();
	}

	void SpawnMyPlayer()
	{
		spawn.Active = true;
		GameObject myPlayer = PhotonNetwork.Instantiate (PlayerPrefabName, 
		                           SpawnPoints[PhotonNetwork.room.playerCount - 1].position,
		                           SpawnPoints[PhotonNetwork.room.playerCount - 1].rotation,
		                           0);
		totPlay++;
		myPlayer.GetComponent<ThirdPersonCharacter> ().enabled = true;
		myPlayer.GetComponent<ThirdPersonCharacter> ().Local_Player = true;
		myPlayer.GetComponent<ThirdPersonUserControl> ().enabled = true;
		myPlayer.GetComponent<PhaseIn> ().enabled = true;
		myPlayer.transform.GetChild (0).GetComponent<Camera> ().enabled = true;
		standby.enabled = false;
	}
}
