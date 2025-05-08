using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void loadscene(string sceneMenu)
    {
        SceneManager.LoadScene(sceneMenu);
    }

    public void quitgame()
    {
        Application.Quit();
        Debug.Log("Adios");
    }
}
