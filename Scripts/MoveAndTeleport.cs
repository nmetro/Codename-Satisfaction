using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndTeleport : MonoBehaviour {
    
    private Vector3 move;

    public Transform startingPos = null;
    public float xDist;
    public float yDist;
    public float xSpeed;
    public float ySpeed;
    public float offsetTime;

	// Use this for initialization
	void Start () {
        startingPos.position = transform.position;
        move = new Vector3(xSpeed / 10, ySpeed / 10, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time < offsetTime)
        {

        } else if (transform.position.x - xDist > startingPos.position.x || transform.position.x + xDist < startingPos.position.x ||
            transform.position.y - yDist > startingPos.position.y || transform.position.y + yDist < startingPos.position.y )
        {
            transform.position = startingPos.position;
        } else        {
            transform.position += move;
        }
	}
}
