using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed = 5f;
    
    
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,50*8*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this);
    }
    
    
}
