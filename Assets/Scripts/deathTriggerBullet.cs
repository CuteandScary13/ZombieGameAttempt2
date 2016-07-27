using UnityEngine;
using System.Collections;

public class deathTriggerBullet : MonoBehaviour {

	void OnTriggerEnter2D( Collider2D activator){
		if (activator.GetComponent<killableByBullet> () != null) {
			Destroy (activator.gameObject);
		}
	}
}
