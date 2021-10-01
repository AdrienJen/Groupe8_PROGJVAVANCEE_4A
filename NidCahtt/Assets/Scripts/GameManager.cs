using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    
    // ------ Variables ----------
   
    [SerializeField]
    private GameObject player1;

    [SerializeField]
    private GameObject player2;

    // ------ Functions ----------
    /// <summary>
    /// Calls the methods Reset if player 1 die.
    /// </summary>
    public void P1Die()
    {
        Destroy(player1);
        Invoke("Reset",1);
    }

    /// <summary>
    /// Calls the methods Reset if player 2 die.
    /// </summary>
    public void P2Die()
    {
       
        Destroy(player2);
        Invoke("Reset",1);
    }

    /// <summary>
    /// Load the scene Menu.
    /// </summary>
    void Reset()
    {
        SceneManager.LoadScene("Menu");
    }


}
