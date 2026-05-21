using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public void goToMainGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
