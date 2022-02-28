using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void loadSelectionMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadGlass1()
    {
        SceneManager.LoadScene("Glass13D");
    }

    public void LoadGlass2()
    {
        SceneManager.LoadScene("Glass23D");
    }

    public void LoadGlass3()
    {
        SceneManager.LoadScene("Glass33D");
    }

}
