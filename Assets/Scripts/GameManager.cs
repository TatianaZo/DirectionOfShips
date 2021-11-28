using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject PopApUI;
    public GameObject BTNNextLVL;
    public GameObject BTNMenu;
    public GameObject BTNRestartLVL;
    public Text PopApUIText;
    public Text scoreText;
    int score = 0;
    public int torpedo { get; private set; }

    private void Start()
    {
        scoreText.text = "" + score;
        if (!PlayerPrefs.HasKey("AllPoint"))
        {
            PlayerPrefs.SetInt("AllPoint", 0);
        }
    }
    public void AddPoint()
    {
        score += 100;
        scoreText.text = ""+ score;
        GameWin();
    }
    

    public void GameWin()
    {
        if (score >= 400)
        {
            PopApUI.SetActive(true);
            PopApUIText.text = " оличество уничтоженных кораблей за эту игру:" + score / 100;
            BTNMenu.SetActive(true);
            BTNNextLVL.SetActive(true);
            PlayerPrefs.SetInt("AllPoint", PlayerPrefs.GetInt("AllPoint") + score);
            PlayerPrefs.Save();
            score = 0;
        }
    }

    public void GameOver()
    {
        PopApUI.SetActive(true);
        PopApUIText.text = " оличество уничтоженных кораблей за эту игру:" + score / 100;
        BTNMenu.SetActive(true);
        BTNRestartLVL.SetActive(true);
        PlayerPrefs.SetInt("AllPoint", PlayerPrefs.GetInt("AllPoint") + score);
        PlayerPrefs.Save();
        score = 0;
    }
}
