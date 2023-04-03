using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public AudioSource source;
    public AudioSource muzyka;
    public AudioClip wingsound;
    public AudioClip deathsound;
    public int dead = 0;



    public float strength = 1;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        dead = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(dead != 1)
            {
                source.PlayOneShot(wingsound);
            }
            

            //rb.AddForce(new Vector2(0, strength), ForceMode2D.Impulse);
            rb.velocity = Vector2.up * strength;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        dead = 1;
        source.PlayOneShot(deathsound);
        
        muzyka.Pause();
        GameManager.Instance.OnGameOver();
    }
}
