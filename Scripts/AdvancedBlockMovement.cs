using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedBlockMovement : MonoBehaviour {
    private GameObject[] checkPoints;
    public GameObject startPosition;
    public GameObject checkPoint1;
    public GameObject checkPoint2;
    public GameObject checkPoint3;
    public GameObject checkPoint4;
    public GameObject checkPoint5;
    public GameObject checkPoint6;
    public GameObject checkPoint7;
    public GameObject checkPoint8;
    public GameObject checkPoint9;
    public GameObject checkPoint10;


    public GameObject cur;
    private int index = 0;
    private float xDist;
    private float yDist;
    private Vector3 xMove;
    private Vector3 yMove;
    
    public bool TeleportBack = false;
    public float Speed;

	// Use this for initialization
	void Start () {
        checkPoints = new GameObject[11];
        checkPoints[0] = startPosition;
        cur = checkPoints[0];
        checkPoints[1] = checkPoint1;
        checkPoints[2] = checkPoint2;
        checkPoints[3] = checkPoint3;
        checkPoints[4] = checkPoint4;
        checkPoints[5] = checkPoint5;
        checkPoints[6] = checkPoint6;
        checkPoints[7] = checkPoint7;
        checkPoints[8] = checkPoint8;
        checkPoints[9] = checkPoint9;
        checkPoints[10] = checkPoint10;

        for (int i = 0; i < checkPoints.Length; i++)
        {
            if (checkPoints[i] == null)
            {
                checkPoints[i] = startPosition;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        xDist = transform.position.x - cur.transform.position.x;
        yDist = transform.position.y - cur.transform.position.y;
        if (Mathf.Abs(xDist) < 0.08 && Mathf.Abs(yDist) < 0.08) {
            index++;
            cur = checkPoints[index % checkPoints.Length];
        } else
        {
            if (Mathf.Abs(xDist) < 0.08)
            {
                xMove = Vector3.zero;
            } else
            {
                xMove = new Vector3(Speed * Time.deltaTime, 0, 0);
            }
            if (Mathf.Abs(yDist) < 0.08)
            {
                yMove = Vector3.zero;
            } else
            {
                yMove = new Vector3(0, Speed * Time.deltaTime, 0);
            }            
            if (xDist > 0)
            {
                transform.position -= xMove;
            } else
            {
                transform.position += xMove;
            }
            if (yDist > 0)
            {
                transform.position -= yMove;
            } else
            {
                transform.position += yMove;
            }
        }
	}
}
