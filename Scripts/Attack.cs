using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    public TurretAI turretAI;

	void Awake()
    {
        turretAI = gameObject.GetComponentInParent<TurretAI>();
    }

    void OnColliderStay2D(Collider2D col)
    {
        //if (col.CompareTag("Player"))
        //{
        //    turretAI.Attack(Time.deltaTime);
        //}
    }
}
