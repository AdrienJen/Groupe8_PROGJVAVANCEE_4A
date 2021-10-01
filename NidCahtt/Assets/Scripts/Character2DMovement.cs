using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DMovement : MonoBehaviour
{
    
    // Script pour gérer les mouvements du joueur

    [SerializeField]
    private float MovementSpeed = 1; // Vitesse de mouvement du joueur
    
    [SerializeField]
    private float JumpForce = 1; // Puissance de saut du joueur

    //[SerializeField] 
    //private GameObject sword;

    [SerializeField] 
    private Animator anim;
    private Rigidbody2D _rigidbody;
    
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal2"); // Utilise les touches A et D pour bouger de gauche à droite
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

        if (Input.GetButtonDown("Jump2") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f) // Si on appuie sur Z, le joueur saute
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        if(Input.GetKeyDown("e")) // Si on appuie sur E, on attaque
        {
            anim.Play("SlashAnimation");
        }
        
        /*if(Input.GetKeyDown("a"))
        {
            sword.gameObject.GetComponent<Bullet>().Throw();
        }
        */
    }
}
