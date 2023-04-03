using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quited");
    }

    public void NewGame()
    {
        SceneManager.LoadScene("2004Chronology");
    }

    public void Credits() 
    {
        Debug.Log("Game by Impax Dev");
    }
}
