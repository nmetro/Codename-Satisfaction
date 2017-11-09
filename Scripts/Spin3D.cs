using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin3D : MonoBehaviour {
    public float speedx;
    public float speedy;
    public float speedz;
    private Vector3 rotation;
    void Start()
    {
        rotation = new Vector3(speedx * Mathf.Cos(Time.time), 
                               speedy * Mathf.Cos(Time.time * 5 / 3), 
                               speedz * Mathf.Cos(Time.time * 7 / 11));
    }
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(rotation);
	}
}
