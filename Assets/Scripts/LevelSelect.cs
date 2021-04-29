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

    public void Update()
    {
        LevelData data;

        if (SaveSystem.Load("Level1") != null)
        {
            data = SaveSystem.Load("Level1");
            timePlaying = TimeSpan.FromSeconds(data.bestTime);
            timePlayingStr = "Best Time: " + timePlaying.ToString("mm':'ss'.'ffff");
            level1BestTime.text = timePlayingStr;

        }
        else if (SaveSystem.Load("Level1") == null)
        {
            timePlayingStr = "Best Time: --:--.--";
            level1BestTime.text = timePlayingStr;
        }

        if (SaveSystem.Load("Level2") != null)
        {
            data = SaveSystem.Load("Level2");
            timePlaying = TimeSpan.FromSeconds(data.bestTime);
            timePlayingStr = "Best Time: " + timePlaying.ToString("mm':'ss'.'ffff");
            level2BestTime.text = timePlayingStr;

        }
        else if (SaveSystem.Load("Level2") == null)
        {
            timePlayingStr = "Best Time: --:--.--";
            level2BestTime.text = timePlayingStr;
        }

        if (SaveSystem.Load("Level3") != null)
        {
            data = SaveSystem.Load("Level3");
            timePlaying = TimeSpan.FromSeconds(data.bestTime);
            timePlayingStr = "Best Time: " + timePlaying.ToString("mm':'ss'.'ffff");
            level3BestTime.text = timePlayingStr;

        }
        else if (SaveSystem.Load("Level3") == null)
        {
            timePlayingStr = "Best Time: --:--.--";
            level3BestTime.text = timePlayingStr;
        }

    }
}