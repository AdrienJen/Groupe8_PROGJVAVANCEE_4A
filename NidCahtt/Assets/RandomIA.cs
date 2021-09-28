using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomIA : MonoBehaviour
{
    [SerializeField]
    private float MovementSpeed = 1;
    
    [SerializeField]
    private float JumpForce = 1;
    
    private Rigidbody2D _rigidbody;
    [SerializeField]
    private int randomNumber;
    
    public Animator anim;
    private GameObject p2;
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        p2=GameObject.FindGameObjectWithTag("Player2");
        InvokeRepeating("TakeRandomNumber",0f,2f);
    }

    // Update is called once per frame
    private void Update()
    {
        
        
        if (randomNumber == 0)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;
        }
        if (randomNumber == 1)
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * MovementSpeed;
        }
        if (randomNumber == 2)
        {
            if (Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
            {
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
        }
        if (randomNumber == 3)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("SwordAttack"))
            {
                anim.Play("SwordAttack");
            }
            
        }
    }

 

    void TakeRandomNumber()
    {
     
        randomNumber = Random.Range(0, 4);
    }
}
