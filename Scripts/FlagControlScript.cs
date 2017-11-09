using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagControlScript : MonoBehaviour {
    private bool hasActivated = false;
    private Vector3 move;

    public float raiseDistance = 0.0f;

    void Start()
    {
        move = new Vector3(0, raiseDistance, 0);
    }
	public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && !hasActivated)
        {
            transform.position = transform.position + move;
            hasActivated = true;
        }
    }
}
