using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;    

public class Menu : MonoBehaviour
{
    // Script pour gérer les boutons du menu
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void Play() //Fonction pour lancer une partie en 1v1
    {
        SceneManager.LoadScene("1 vs 1");
    }

    public void PlayAI() //Fonction pour lancer une partie en 1vIA
    {
        SceneManager.LoadScene("vs ai");
    }

    public void Quit() //Fonction pour fermer le jeu
    {
        Application.Quit();
    }
}
