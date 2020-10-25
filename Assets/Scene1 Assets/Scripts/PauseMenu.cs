using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject pauseMenu;
    public GameObject pauseMenuCamera;
    public GameObject mainCamera;
    public GameObject boatCamera;
    public GameObject player;

    private void Start()
    {
        pauseMenu.SetActive(false);
        pauseMenuCamera.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        if (player.GetComponent<PlayerManager>().boatInControl)
        {
            boatCamera.SetActive(true);
        }
        else
        {
            mainCamera.SetActive(true);
        }
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void Pause()
    {
        if (player.GetComponent<PlayerManager>().boatInControl)
        {
            boatCamera.SetActive(false);
        }
        else
        {
            mainCamera.SetActive(false);
        }
        pauseMenu.SetActive(true);
        pauseMenuCamera.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void LoadOptionsMenu()
    {
        // TODO
    }

    public void QuitGame()
    {
        Application.Quit(0);
    }
}
