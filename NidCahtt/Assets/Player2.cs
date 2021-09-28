using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    private GameObject p2;
    
    // Start is called before the first frame update
    void Start()
    {
        p2=GameObject.FindGameObjectWithTag("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Player2"))
        {
            Destroy(p2);
        }
       
    }
}
