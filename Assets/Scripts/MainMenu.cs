using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    void Awake()
    {
        SaveSystem.CreateDirectory();
    }

}
