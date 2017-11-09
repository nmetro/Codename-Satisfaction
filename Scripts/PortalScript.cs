using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour {
    public Transform otherDoor;

	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Portal")
        {
            //col.gameObject.transform = otherDoor;
        }
    }
}
