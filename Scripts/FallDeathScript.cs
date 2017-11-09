using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeathScript : RespawnScript {
    public float bottom = -20f;	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottom)
        {
            respawn();
        }
	}
}

