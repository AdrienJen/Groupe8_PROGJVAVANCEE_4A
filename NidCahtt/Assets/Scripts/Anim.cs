using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    
    public Animator test;
   
    void Start()
    {
        test = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            test.Play("swingSword");    
        }

    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        throw new NotImplementedException();
    }
    
}
