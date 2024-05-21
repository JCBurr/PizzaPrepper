using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void OnPressStartGameButton()
    {
        Debug.Log("Start game");
        SceneManager.LoadSceneAsync("Game");
    }

    public void OnPressQuitGameButton()
    {
        Debug.Log("Application quit");
        Application.Quit();
    }
}
