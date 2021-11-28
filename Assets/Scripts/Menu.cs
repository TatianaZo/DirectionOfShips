using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text allScoreText;
    void Start()
    {
       // Debug.Log(PlayerPrefs.GetInt("AllPoint"));
        allScoreText.text = "All ships destroyed" + "\n" + PlayerPrefs.GetInt("AllPoint") / 100;
    }
}
