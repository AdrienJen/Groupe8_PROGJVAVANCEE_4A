using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class p2AttackAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator test;
    private GameObject p1;
    
    void Start()
    {
        test = GetComponent<Animator>();
        p1=GameObject.FindGameObjectWithTag("Player");
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
        if (coll.gameObject.CompareTag("Player") && test.GetCurrentAnimatorStateInfo(0).IsName("SwordAttack"))
        {
            Destroy(p1);
            Invoke("Die", 2);
        }
       
    }

    void Die()
    {
        SceneManager.LoadScene(0);
    }
}
