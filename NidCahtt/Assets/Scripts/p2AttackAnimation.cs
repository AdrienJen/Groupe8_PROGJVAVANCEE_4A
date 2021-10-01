using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class p2AttackAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    [SerializeField]
    private GameObject p1;
    [SerializeField]
    private GameManager gm;

    [SerializeField] private Animator player2Anim;
    
    void Start()
    {
        anim =GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        
        if (coll.gameObject==p1 && player2Anim.GetCurrentAnimatorStateInfo(0).IsName("SlashAnimation"))
        {
            gm.GetComponent<GameManager>().P1Die();
        }
       
    }
    
    
    
}
