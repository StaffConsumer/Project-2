using UnityEngine;
using System.Collections;

public class DeleteBlock : MonoBehaviour {

	public GameObject expl;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		GameObject obj = col.gameObject;
		if(obj.tag == "Cube")
		{
			Destroy (obj);
		}
		else if(obj.tag == "Player")
		{
			UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl tus = obj.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>();
			if(obj.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>().Local_Player && tus != null)
			{
				obj.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().Dead = true;
				PhotonNetwork.Instantiate("Explosion", obj.transform.position, obj.transform.rotation, 0);
				obj.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>().enabled = false;
				obj.transform.GetChild(1).transform.GetComponent<SkinnedMeshRenderer>().enabled = false;
			}
			else if(tus == null)
			{
				GameObject.Instantiate(expl, obj.transform.position, obj.transform.rotation);
			}
		}
	}
}
