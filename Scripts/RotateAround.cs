using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {
    public Transform pivot;
    public float speed;

    private Vector3 point;
	// Update is called once per frame
	void Update () {
        point = pivot.position;
        transform.RotateAround(point, Vector3.up, speed * Time.deltaTime);
	}
}
