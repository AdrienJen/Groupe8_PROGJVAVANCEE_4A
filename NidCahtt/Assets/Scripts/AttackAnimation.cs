using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackAnimation : MonoBehaviour
{
    
    [SerializeField]
    private GameObject p2;
    [SerializeField]
    private GameManager gm;
    
    [SerializeField] 
    private Animator player1Anim;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown("p"))
        
    
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject==p2 && player1Anim.GetCurrentAnimatorStateInfo(0).IsName("SlashAnimation"))
        {
            gm.GetComponent<GameManager>().P2Die();
        }
       
    }
}
