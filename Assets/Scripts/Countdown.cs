using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public static bool GameStart = false;

    private void Start()
    {
        GameStart = false;
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "GO!";



        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);

        GameStart = true;

        TimerController.instance.BeginTimer();

    }

}
