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
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
       
        InvokeRepeating("TakeRandomNumber",0f,2f);
    }

    // Update is called once per frame
    private void Update()
    {
        
        
        if (randomNumber == 0)
        {
            int moveright=1;
            transform.position += new Vector3(moveright, 0, 0) * Time.deltaTime * MovementSpeed;
            transform.rotation = moveright < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
        if (randomNumber == 1)
        {
            int moveleft=-1;
            transform.position += new Vector3(moveleft, 0, 0) * Time.deltaTime * MovementSpeed;
            if (!Mathf.Approximately(0, moveleft))
            {
                transform.rotation = moveleft < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
            }
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
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("SlashAnimation"))
            {
                anim.Play("SlashAnimation");
            }
            
        }
    }

 

    void TakeRandomNumber()
    {
     
        randomNumber = Random.Range(0, 4);
    }
}
