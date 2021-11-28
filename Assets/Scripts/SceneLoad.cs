using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{ 
    public void LVL1()
    {
        PlayerPrefs.SetString("PointShip", "LVL1");
        SceneManager.LoadScene("LVL1");
    }

    public void LVL2()
    {
        PlayerPrefs.SetString("PointShip", "LVL2");
        SceneManager.LoadScene("LVL2");
    }
    public void LVL3()
    {
        PlayerPrefs.SetString("PointShip", "LVL3");
        SceneManager.LoadScene("LVL3");
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
