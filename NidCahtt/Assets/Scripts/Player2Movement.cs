using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    
    // Script qui réplique le script "Character2DMovement" pour le joueur 2
    
    [SerializeField]
    private float MovementSpeed = 1;
    
    [SerializeField]
    private float JumpForce = 1;

    //[SerializeField] private GameObject sword;

    [SerializeField] 
    private Animator anim;
    private Rigidbody2D _rigidbody;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        transform.rotation = -1 < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
    }

    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        if(Input.GetKeyDown("p"))
        {
            anim.Play("SlashAnimation");
        }
    }
}
