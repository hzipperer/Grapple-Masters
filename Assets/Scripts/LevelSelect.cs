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
        double Master1Time = 9.0000;
        double Master2Time = 35.0000;
        double Master3Time = 95.0000;

        if (SaveSystem.Load("Level1") != null)
        {
            data = SaveSystem.Load("Level1");
            Debug.Log("Level1 Time: " + data.bestTime);
            timePlaying = TimeSpan.FromSeconds(data.bestTime);
            timePlayingStr = "Best Time: " + timePlaying.ToString("mm':'ss'.'ffff");
            level1BestTime.text = timePlayingStr;
            if (data.bestTime < Master1Time)
            {
                level1BestTime.color = new Color32(255, 189, 57, 255);
            }
            else
            {
                level1BestTime.color = new Color32(255, 255, 255, 255);
            }

        }
        else if (SaveSystem.Load("Level1") == null)
        {
            timePlayingStr = "Best Time: --:--.--";
            level1BestTime.text = timePlayingStr;
        }

        if (SaveSystem.Load("Level2") != null)
        {
            data = SaveSystem.Load("Level2");
            Debug.Log("Level2 Time: " + data.bestTime);
            timePlaying = TimeSpan.FromSeconds(data.bestTime);
            timePlayingStr = "Best Time: " + timePlaying.ToString("mm':'ss'.'ffff");
            level2BestTime.text = timePlayingStr;
            if (data.bestTime < Master2Time)
            {
                level2BestTime.color = new Color32(255, 189, 57, 255);
            }
            else
            {
                level2BestTime.color = new Color32(255, 255, 255, 255);
            }

        }
        else if (SaveSystem.Load("Level2") == null)
        {
            timePlayingStr = "Best Time: --:--.--";
            level2BestTime.text = timePlayingStr;
        }

        if (SaveSystem.Load("Level3") != null)
        {
            data = SaveSystem.Load("Level3");
            Debug.Log("Level3 Time: " + data.bestTime);
            timePlaying = TimeSpan.FromSeconds(data.bestTime);
            timePlayingStr = "Best Time: " + timePlaying.ToString("mm':'ss'.'ffff");
            level3BestTime.text = timePlayingStr;
            if (data.bestTime < Master3Time)
            {
                level3BestTime.color = new Color32(255, 189, 57, 255);
            }
            else
            {
                level3BestTime.color = new Color32(255, 255, 255, 255);
            }

        }
        else if (SaveSystem.Load("Level3") == null)
        {
            timePlayingStr = "Best Time: --:--.--";
            level3BestTime.text = timePlayingStr;
        }

    }
}