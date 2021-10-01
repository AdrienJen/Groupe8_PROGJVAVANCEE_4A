using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1Animation : MonoBehaviour
{
    // ------ Variables ----------
    [SerializeField]
    private GameObject p2;
    [SerializeField]
    private GameManager gm;
    
    [SerializeField] 
    private Animator player1Anim;
// ------ Functions ----------

//Calls the methods P2Die, if on trigger enter during the animation and with the collider of player 2.
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject==p2 && player1Anim.GetCurrentAnimatorStateInfo(0).IsName("SlashAnimation"))
        {
            gm.GetComponent<GameManager>().P2Die();
        }
       
    }
}
