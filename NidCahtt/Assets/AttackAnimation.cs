using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackAnimation : MonoBehaviour
{
    private Animator anim;
    [SerializeField]
    private GameObject p2;
    [SerializeField]
    private GameManager gm;
    
    void Start()
    {
        anim = GetComponent<Animator>();
   
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown("p"))
        
            
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject==p2 && anim.GetCurrentAnimatorStateInfo(0).IsName("SwordAttack"))
        {
            gm.GetComponent<GameManager>().P2Die();
        }
       
    }
    
    
    public void Attack()
    {
        
        anim.Play("SwordAttack");
        
    }
}
