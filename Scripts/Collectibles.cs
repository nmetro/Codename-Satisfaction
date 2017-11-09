using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour {
    private int pickups = 0;
    public Text pickupText;

    void Start()
    {
        pickupText.text = "Collectibles: 0";
    }
	void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Pickup")
        {
            pickups++;
            col.gameObject.SetActive(false);
            setText();
        }
    }
    void setText()
    {
        pickupText.text = "Collectibles: " + pickups.ToString();
    }
}
