using UnityEngine;
using System.Collections;

public class ZombieMovement : MonoBehaviour {
	public float moveSpeed;
	GameObject player;
	public float distanceFromPlayer = 0.25f;
	// Use this for initialization
	void Start () {
		
		player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (this.transform.position, player.transform.position) > distanceFromPlayer) {
			transform.position += Vector3.Normalize (player.transform.position - this.transform.position) * moveSpeed * Time.deltaTime;
		}
	}


}

