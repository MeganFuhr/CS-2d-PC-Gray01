using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_YouLost : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.GetSceneByBuildIndex(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
