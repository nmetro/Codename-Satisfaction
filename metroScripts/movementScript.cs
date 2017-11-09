using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Simply moves the current game object
public class movementScript : MonoBehaviour
{

	public float speed;
	public GameObject target;

	public Vector2 maxBounds;
	public Vector2 minBounds;

	public int tickLimit;
	private int tick;

	public Transform respawnPoint;

	void Update()
	{
		Vector2 pos = GameObject.Find(target.name).transform.position;

		float step = speed * Time.deltaTime;
		if ((pos.x > minBounds.x && pos.x < maxBounds.x) && (pos.y > minBounds.y && pos.y < maxBounds.y)){
			transform.position = Vector2.MoveTowards (transform.position, pos, step);
			tick = 0;
		} else
			tick++;
		
		if (tick > tickLimit) {
			transform.position = Vector2.MoveTowards (transform.position, respawnPoint.position, step);
		}
	}

	public void respawn () {
		transform.position = respawnPoint.position;
	}

}
