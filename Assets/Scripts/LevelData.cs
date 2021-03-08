using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    public string level;
    public float bestTime;

    public LevelData (TimerController time)
    {
        level = time.level;
        bestTime = time.elapsedTime;
    }
}
