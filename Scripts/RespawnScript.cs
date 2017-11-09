using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnScript : MonoBehaviour {

    public Transform respawnPoint = null;
    public Rigidbody2D rb2d = null;
    public Text deathText;
    public float bottom = -20f;

    private int deathCount = 0;
    private bool[] primes = new bool[0];
    private int primeCount = 0;

    void Start()
    {
        respawnPoint.position = transform.position;
        rb2d = GetComponent<Rigidbody2D>();
        deathText.text = "Deaths: 0";
        primes = generatePrimes(10000);
    }
    void Update()
    {
        if(transform.position.y < bottom)
        {
            respawn();
        }
    }
    public void respawn()
    {
        rb2d.velocity = Vector3.zero;
        rb2d.velocity = Vector2.zero;
        rb2d.rotation = 0.0f;
        transform.position = respawnPoint.position;
        deathCount++;
        setText();
        if (deathCount < primes.Length)
        {
            if (primes[deathCount])
            {
                primeCount++;
                if (primeCount > 0 && primeCount % 13 == 0)
                {
                    deathText.text += " (spooky)";
                }
            }
        }
    }
	public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Flag")
        {
            respawnPoint.position = transform.position + new Vector3(0, 3, 0);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Spike" ||
            col.gameObject.tag == "Bullet")
        {
            respawn();
        }
        if (col.gameObject.tag == "MovingBlock")
        {
            this.transform.parent = col.gameObject.transform;
        } else
        {
            this.transform.parent = GameObject.Find("OriginEmpty").transform;
        }
    }
    void OnCollisionExit2D(Collision2D col)      
    {
        if (col.gameObject.tag != "MovingBlock")
        {
            this.transform.parent = GameObject.Find("OriginEmpty").transform;
        }
    }
    void setText()
    {
        deathText.text = "Deaths: " + deathCount.ToString();
    }
    private bool[] generatePrimes (int max)
    {
        // Make an array indicating whether numbers are prime.
        bool[] is_prime = new bool[max + 1];
        for (int i = 2; i <= max; i++) is_prime[i] = true;

        // Cross out multiples.
        for (int i = 2; i <= max; i++)
        {
            // See if i is prime.
            if (is_prime[i])
            {
                // Knock out multiples of i.
                for (int j = i * 2; j <= max; j += i)
                    is_prime[j] = false;
            }
        }
        return is_prime;
    }

}
