using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public TextMeshProUGUI level1BestTime;
    public TextMeshProUGUI level2BestTime;
    public TextMeshProUGUI level3BestTime;

    private float elapsedTime;
    private TimeSpan timePlaying;
    private string timePlayingStr;

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
}