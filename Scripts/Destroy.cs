using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    public int test = 1;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
	}

    void OnCollisionStay2D(Collision2D col)
    {
        Destroy(gameObject);
    }
}
