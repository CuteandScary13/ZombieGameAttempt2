using UnityEngine;
using System.Collections;

public class SpawnZombies : MonoBehaviour {

	public GameObject zombie;
	ZombieMovement zombMove;
	public float varTime = 2f;
	public float repeatRate = 0.3f;
	public float moveSPeed = 0.5f;

	// Use this for initialization
	void Start () {
		zombMove = zombie.GetComponent<ZombieMovement> ();
		InvokeRepeating ("spawnZombie", varTime, repeatRate);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Functions and stuff

	void spawnZombie(){
		zombMove.moveSpeed = this.moveSPeed;
		Instantiate (zombie, new Vector3(Random.Range(-5f,5f), Random.Range(-5f,5f), 0f), Quaternion.Euler(0f,0f,0f) );

	}

}
