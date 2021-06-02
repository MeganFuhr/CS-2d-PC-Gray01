using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_YouLost : MonoBehaviour
{
    private Canvas youLost;
    private GameObject go;

    public void PlayGame()
    {
        go = GameObject.Find("/UI");
        youLost = go.transform.GetChild(0).gameObject.GetComponent<Canvas>();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        youLost.enabled = false;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
