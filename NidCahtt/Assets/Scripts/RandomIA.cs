using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomIA : MonoBehaviour
{
    // ------ Variables ----------
    [SerializeField]
    private float MovementSpeed = 1;
    
    [SerializeField]
    private float JumpForce = 1;
    
    private Rigidbody2D _rigidbody;
    [SerializeField]
    private int randomNumber;
    
    public Animator anim;
    
    // ------ Functions ----------
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
       
        //Call the function takeRandomNumber at the start each 2s 
        InvokeRepeating("TakeRandomNumber",0f,2f);
    }

    
    private void Update()
    {
        
      RandomMove();
       
    }

    /// <summary>
    /// Do a move depending on the number of (int)randomNumber.
    /// </summary>
    void RandomMove()
    {
        if (randomNumber == 0)
        { 
            //move the IA to the right
            int moveright=1;
            transform.position += new Vector3(moveright, 0, 0) * Time.deltaTime * MovementSpeed;
            transform.rotation = moveright < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
        if (randomNumber == 1)
        {
            //move the IA to the left
            int moveleft=-1;
            transform.position += new Vector3(moveleft, 0, 0) * Time.deltaTime * MovementSpeed;
            if (!Mathf.Approximately(0, moveleft))
            {
                transform.rotation = moveleft < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
            }
        }
        if (randomNumber == 2)
        {
            //IA jump
            if (Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
            {
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
        }
        if (randomNumber == 3)
        {
            //IA attack
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("SlashAnimation"))
            {
                anim.Play("SlashAnimation");
            }
            
        }
    }
    /// <summary>
    /// Take a random number between 0 and 4.
    /// </summary>
    void TakeRandomNumber()
    {
     
        randomNumber = Random.Range(0, 4);
    }
}
