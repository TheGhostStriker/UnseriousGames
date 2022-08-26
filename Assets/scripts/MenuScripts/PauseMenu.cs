using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseButtonHIDE;
    public GameObject nextSceneButtonHIDE;
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        pauseButtonHIDE.SetActive(false);
        nextSceneButtonHIDE.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pauseButtonHIDE.SetActive(true);
        nextSceneButtonHIDE.SetActive(true);
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

}
