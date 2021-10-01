using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    // Script pour gérer le menu pause
    
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Si on appuie sur Echap
        {
            if (GameIsPaused) // Si le jeu est deja en pause
            {
                Resume(); 
            }
            else
            {
                Pause(); 
            }
        }
    }
    
    // Un belge a battu le record du 100 métres, il en a fait 200 :)

    public void Resume() // Relance le jeu
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause() // Met le jeu en pause
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu() // Charge l'écran de menu principal
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame() // Ferme le jeu
    {
        Application.Quit();
    }
}
