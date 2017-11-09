using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDeathScript : RespawnScript {

	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Spike" ||
            col.gameObject.tag == "Bullet")
        {
            respawn();
        }
    }
}
