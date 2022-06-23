using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // access UI elements
using UnityEngine.SceneManagement; //access scene manager

public static class GlobalTime
{
    public static string OverallTime;

    public static string Level1Time;

    public static string Level2Time;

    public static string Level3Time;
}

public static class Globalrank
{
    public static string OverallPerformance;

    public static int LevelPerformance = 0;
}

public class Timer : MonoBehaviour
{
    public float LevelTime; //store time
    public Text RemainingTime; //Reference point for time text

    // Start is called before the first frame update
    void Start()
    {
        RemainingTime.text = "Time: " + LevelTime; //set level time
    }

    // Update is called once per frame
    void Update()
    {
        LevelTime -= Time.deltaTime;
        RemainingTime.text = Mathf.Round(LevelTime * 1) / 1 + "";

        GlobalTime.OverallTime = RemainingTime.text;

        if (Mathf.Round(LevelTime * 1) / 1 < 60)
        {
            Globalrank.OverallPerformance = "Not bad";
        }
        else if (Mathf.Round(LevelTime * 1) / 1 >= 60 && Mathf.Round(LevelTime * 1) / 1 < 120)
        {
            Globalrank.OverallPerformance = "Good";
        }
        else if (Mathf.Round(LevelTime * 1) / 1 >= 120)
        {
            Globalrank.OverallPerformance = "Great";
        }
        else Globalrank.OverallPerformance = "unknown";


        if (LevelTime < 0) //if time below 0
        {
            if (GlobalLevel.LevelCount == 1)
            {
                Destroy(gameObject); //destroy character
                SceneManager.LoadScene("L1 Timeout Scene"); //load timeout scene
            }
            else if (GlobalLevel.LevelCount == 2)
            {
                Destroy(gameObject); //destroy character
                SceneManager.LoadScene("L2 Timeout Scene"); //load timeout scene
            }
            else if (GlobalLevel.LevelCount == 3)
            {
                Destroy(gameObject); //destroy character
                SceneManager.LoadScene("L3 Timeout Scene"); //load timeout scene
            }
        }
    }
}
