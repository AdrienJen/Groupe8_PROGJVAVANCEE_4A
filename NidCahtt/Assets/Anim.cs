using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    // Start is called before the first frame update
    public Animation test;
    private GameObject p2;
    void Start()
    {
        //test = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            test.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        throw new NotImplementedException();
    }
}
