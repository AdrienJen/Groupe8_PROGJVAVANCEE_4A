using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Animation : MonoBehaviour
{
  
    // ------ Variables ----------
    [SerializeField]
    private GameObject p1;
    [SerializeField]
    private GameManager gm;

    [SerializeField] private Animator player2Anim;
    
    // ------ Functions ----------
    
    //Calls the methods P1Die, if on trigger enter during the animation and with the collider of player 1.
    void OnTriggerEnter2D(Collider2D coll)
    {
        
        if (coll.gameObject==p1 && player2Anim.GetCurrentAnimatorStateInfo(0).IsName("SlashAnimation"))
        {
            gm.GetComponent<GameManager>().P1Die();
        }
       
    }
    
    
    
}
