using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour {    
    public float leftRightDistance;
    public float upDownDistance;
    public float LRspeed;
    public float UDspeed;
    public float LRtimeOffset;
    public float UDtimeOffset;
    private Vector3 startPosition;
    private Vector3 move;

    void Start()
    {
        startPosition = transform.position;
        move = new Vector3(leftRightDistance, 0, 0);
        if (LRspeed == 0)
        {
            LRspeed = 1f;
        }
        if (UDspeed == 0)
        {
            UDspeed = 1f;
        }
    }
	// Update is called once per frame
	void Update () {
        
        move = new Vector3(leftRightDistance * (float)System.Math.Cos((Time.time * LRspeed) + LRtimeOffset), 
                            upDownDistance * (float)System.Math.Cos((Time.time * UDspeed) + UDtimeOffset), 0);
        transform.position = startPosition + move;
	}
}
