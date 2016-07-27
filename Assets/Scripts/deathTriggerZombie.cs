using UnityEngine;
using System.Collections;

public class deathTriggerZombie : MonoBehaviour {

	void OnTriggerEnter2D( Collider2D activator){
		if (activator.GetComponent<killableByZombie> () != null) {
			Destroy (activator.gameObject);
		}
	}


}
