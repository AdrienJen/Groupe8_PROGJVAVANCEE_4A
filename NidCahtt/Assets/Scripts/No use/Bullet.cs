using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // ------ Variables ----------
    [SerializeField]
    private float speed = 5f;

    private bool isThrow = false;
    
    public Rigidbody2D rb;
    
    // ------ Functions ----------
    void Start()
    {
        
        //rb.velocity = transform.right * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (isThrow)
        {
            transform.Rotate(0,0,50*8*Time.deltaTime);
        }
        */
    }
    /// <summary>
    /// Move the object depending on the speed and rotate him
    /// </summary>
    public void Throw()
    {
        rb.velocity = transform.right * speed;
        transform.Rotate(0,0,50*8*Time.deltaTime);
    }
    //destroy bullet
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this);
    }
    
    
}
