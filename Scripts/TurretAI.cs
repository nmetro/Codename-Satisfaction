using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAI : MonoBehaviour {
    
    //floats
    public float distance;
    public float range;
    public float rateOfFire;
    public float bulletSpeed = 100f;
    public float bulletTimer = 0;

    public Vector2 direction;

    //bools
    public bool awake = false;

    //References
    public GameObject bullet;
    public Transform target;
    public Transform shootPoint;

    void Awake() {
        //anim = gameObject.GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        RangeCheck();
	}

    void RangeCheck()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);

        if (distance < range && target.transform.position.y < transform.position.y - 1)
        {
            awake = true;
        }
        else
        {
            awake = false;
        }
        if (awake)
        {
            bulletTimer += Time.deltaTime;

            if (bulletTimer >= rateOfFire)
            {
                direction = target.transform.position - transform.position;
                //direction.Normalize();
                GameObject bulletClone;
                bulletClone = (GameObject)Instantiate(bullet, shootPoint.transform.position, shootPoint.rotation);
                bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
                bulletTimer = 0;
            }
        }
    }
    //public void Attack(float bulletTimer)
    //    bulletTimer += Time.deltaTime;
    //
    //    if (bulletTimer >= rateOfFire)
    //    {
    //        Vector2 direction = target.transform.position - transform.position;
    //        direction.Normalize();
    //        GameObject bulletClone;
    //        bulletClone = (GameObject)Instantiate(bullet, shootPoint.transform.position, shootPoint.rotation);
    //        bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    //        //bulletTimer = 0;
    //    }
    //}
}
