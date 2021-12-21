using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject otherCanvasUI;


    public AudioSource audioSource;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }

        }

    }

    public void Resume()
    {
        
        pauseMenuUI.SetActive(false);
        otherCanvasUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;

        audioSource.Play();

    }

    void Paused()
    {
        pauseMenuUI.SetActive(true);
        otherCanvasUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;

        audioSource.Pause();

    }

}
