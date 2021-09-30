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
    
    void Start()
    {
        anim =GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void Attack()
    {
        
            anim.Play("SwordAttack");
        
    }
    
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("test");
        if (coll.gameObject==p1 && anim.GetCurrentAnimatorStateInfo(0).IsName("SwordAttack"))
        {
            gm.GetComponent<GameManager>().P1Die();
        }
       
    }
    
    
    
}
