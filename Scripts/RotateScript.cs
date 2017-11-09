using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {
    public float speed;
    public float varianceSpeed;
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.back * Time.deltaTime * speed * Mathf.Cos(Time.time * varianceSpeed));
	}
}
