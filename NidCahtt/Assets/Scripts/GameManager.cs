using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject player1;

    [SerializeField]
    private GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void P1Die()
    {
        Destroy(player1);
        Invoke("Reset",1);
    }

    public void P2Die()
    {
        Debug.Log("test");
        Destroy(player2);
        Invoke("Reset",1);
    }

    void Reset()
    {
        SceneManager.LoadScene("Menu");
    }


}
