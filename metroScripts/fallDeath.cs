using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDeath : MonoBehaviour {

	public float bottom;
	public Transform respawnPoint;

	//initialization
	void Start () {
		respawnPoint.position = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottom) {
			respawn ();
		}
	}
	public void respawn () {
		transform.position = respawnPoint.position;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Enemy") {
			respawn ();
		}
	}
}
