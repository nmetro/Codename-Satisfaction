using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayAttackEnemy : MonoBehaviour {
	public Vector2 maxBounds;
	public Vector2 minBounds;

	public int resetTickLimit;
	private int resetTick;

	public int waitTickLimit;
	private int waitTick;

	public int followTickLimit;
	private int followTick;

	public GameObject target;
	public Vector2 distanceFromPlayer;

	public float attackSpeed;
	public float resetSpeed;
	public float followSpeed;


	public Transform respawnPoint;

	private bool attackBool = true;
	private Vector2 attackPos = Vector2.zero;


	void FixedUpdate () {
		Vector2 playerPos = GameObject.Find(target.name).transform.position;
		float attackStep = attackSpeed * Time.deltaTime;
		float resetStep = resetSpeed * Time.deltaTime;
		float followStep = followSpeed * Time.deltaTime;


		if ((playerPos.x > minBounds.x && playerPos.x < maxBounds.x) && (playerPos.y > minBounds.y && playerPos.y < maxBounds.y)) {
			Vector2 enemyPos = transform.position;
			if (enemyPos != playerPos + distanceFromPlayer && 
				waitTick < waitTickLimit) {
				transform.position = Vector2.MoveTowards (transform.position, playerPos + distanceFromPlayer, followStep);
				attackBool = true;
			} else if (waitTick > waitTickLimit) {
				followTick++;
				if (attackBool == true) {
					attackPos = playerPos;
					attackBool = false;
				}
				this.transform.parent = null;
				transform.position = Vector2.MoveTowards (transform.position, attackPos, attackStep);
				//this.transform.parent = GameObject.Find("OriginEmpty").transform;
				if (followTickLimit < followTick) {
					followTick = 0;
					waitTick = 0;
				}
			} else {
				this.transform.parent = GameObject.Find(target.name).transform;
				attackBool = true;

			}
			resetTick = 0;
			waitTick++;
		} else {
			this.transform.parent = GameObject.Find("OriginEmpty").transform;
			resetTick++;
		}
			
		if (resetTick > resetTickLimit) {
			transform.position = Vector2.MoveTowards (transform.position, respawnPoint.position, resetStep);
		}

	}
}
