using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	Vector3 cursorPositionInWorld;
	Vector2 moveVector = new Vector2(0f,0f);
	Rigidbody2D myRigidbody;
	public float speed = 5f;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
		cursorPositionInWorld = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		cursorPositionInWorld.z = 0f;
	}

	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		moveVector = new Vector2 (horizontal, vertical);
		if (moveVector.magnitude > 1f) {
			moveVector = moveVector.normalized;
		}

		cursorPositionInWorld = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		cursorPositionInWorld.z = 0f;
		this.transform.up = cursorPositionInWorld - this.transform.position;

	}
	//runs physics
	void FixedUpdate(){
		//myRigidbody.velocity= new Vector2(0f,0f);
		//= Vector2.zero

		myRigidbody.velocity= moveVector*speed;

	}
}
