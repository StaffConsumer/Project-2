using UnityEngine;
using System.Collections;

public class TWController : MonoBehaviour {

	public float Speed = 1f;
	private CharacterController cc;
	private Vector3 Acceleration;
	private Vector3 Velocity;
	private Vector3 Gravity;

	// Use this for initialization
	void Start () 
	{
		cc = GetComponent<CharacterController> ();
		Gravity = new Vector3 (0, -.1f, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		CollisionFlags CF = cc.Move (Vector3.right * h * Speed + Vector3.forward * v * Speed);

		Acceleration = Gravity;
		Velocity += Acceleration;

		Vector3 newPosition = cc.transform.position;
		Vector3 positionWithGravity = newPosition + Velocity;

		Vector3 otherMove = positionWithGravity - newPosition;

		CollisionFlags CF2 = cc.Move (otherMove);

		if(cc.isGrounded || CF2 == CollisionFlags.CollidedBelow)
		{
			Velocity = Vector3.zero;
			//this.transform.position -= otherMove;
			cc.Move (-otherMove);
		}
		else
		{

		}


	}
}
