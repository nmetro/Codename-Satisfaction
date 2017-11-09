using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlocksScript : MonoBehaviour {

    void OnCollsionStay2D(Collision2D col)
    {
        if(col.gameObject.tag == "MovingBlock")
        {
            transform.parent = col.gameObject.transform;
        }
    }
}
