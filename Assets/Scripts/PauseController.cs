using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [SerializeField]
    GameObject pausePanel;
    [SerializeField]
    GameObject settingsPanel;

    void Start()
    {
        CameraFollower camera = FindObjectOfType<CameraFollower>();

    }
    public void Pause()
    {
        pausePanel.SetActive(true);
        settingsPanel.SetActive(false);
        Time.timeScale = 0.0F;
    }
    public void Home()
    {
        Debug.Log("Welcome scene");
    }
    public void Resume()
    {
        pausePanel.SetActive(false);
        settingsPanel.SetActive(true);
        Time.timeScale = 1.0F;
    }
    public void Reload()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0F;
    }
}
