using UnityEngine;
using System.Collections;

public class FallingBlock : MonoBehaviour {

	[HideInInspector]
	public bool Triggered =  false;

	public float speed = .1f;
	public int TimeToFall = 60;
	[HideInInspector]
	public int TimeToFallReset = 60;

	public GameObject WinnerCanvas;
	public GameObject GameOverCanvas;

	// Use this for initialization
	void Start () 
	{
		TimeToFall += Random.Range (0, 3 * 60);
		TimeToFallReset = TimeToFall;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Triggered)
		{
			TimeToFall--;

			if(TimeToFall <= 120)
			{
				this.transform.position -= Vector3.up * speed / 10;
			}
			else if(TimeToFall <= 0)
			{

				this.GetComponent<Rigidbody> ().velocity += Vector3.down * speed;
				this.GetComponent<Rigidbody> ().AddForce (Vector3.down * speed);
				this.transform.position -= Vector3.up * speed;

				if(this.transform.position.y < - 20)
				{
					GameObject.Destroy(this.gameObject);
				}
			}

			if(WinnerCanvas.activeInHierarchy || GameOverCanvas.activeInHierarchy)
			{
				Triggered = false;
			}
		}
	}

	void Fall()
	{
		this.GetComponent<Rigidbody> ().AddRelativeForce (Vector3.down * speed);
		Triggered = true;
	}

	void OnCollisionEnter(Collision c)
	{
		if(c.gameObject.tag.Equals("Player"))
		{
			Fall();
		}
		else if(c.gameObject.tag == "Bullet")
		{
			Destroy(c.gameObject);
		}
	}

	void OnTriggerEnter(Collider c)
	{
		if(c.gameObject.tag.Equals("Player"))
		{
			Fall();
		}

		else if(c.gameObject.tag == "Bullet")
		{
			Destroy(c.gameObject);
		}

	}
}
