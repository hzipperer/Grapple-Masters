using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public string name;
    public float time = 0f;

    void OnCollisionEnter(Collision col)
    {
        float tempTime;
        LevelData data;

        if (col.gameObject.name == "Goal")
        {
            time = TimerController.instance.elapsedTime;

            if (SaveSystem.Load(name) != null)
            {
                data = SaveSystem.Load(name);
                tempTime = data.bestTime;

                if (time < tempTime)
                {
                    SaveSystem.Save(this);
                }

            }
            else if (SaveSystem.Load(name) == null)
            {
                SaveSystem.Save(this);
            }
        }
    }

    void Awake()
    {
        name = SceneManager.GetActiveScene().name;
    }
}