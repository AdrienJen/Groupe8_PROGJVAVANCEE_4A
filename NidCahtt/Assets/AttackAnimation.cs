using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator test;
    private GameObject p2;
    
    void Start()
    {
        test = GetComponent<Animator>();
        p2=GameObject.FindGameObjectWithTag("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("x"))
        {
            test.Play("SwordAttack");
        }
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Player2") && test.GetCurrentAnimatorStateInfo(0).IsName("SwordAttack"))
        {
            Destroy(p2);
        }
       
    }
    
}
