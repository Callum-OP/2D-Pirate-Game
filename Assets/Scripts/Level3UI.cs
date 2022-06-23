using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // allows for scene management
using UnityEngine.UI;

public class Level3UI : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("Final Scoreboard");
    }

    public void RestartLevelScoreboard()
    {
        SceneManager.LoadScene("Level 3"); //Locate and load current level scene
    }

    public void RestartLevelDeath()
    {
        SceneManager.LoadScene("Level 3"); //Locate and load current level scene
    }

    public void RestartLevelTimeout()
    {
        SceneManager.LoadScene("Level 3"); //Locate and load current level scene
    }

    public void ResetData()
    {
        Globalkills.Overallkills = 0;

        Globalkills.Level3kills = 0;

        Globalpoints.OverallChests = 0;

        Globalpoints.OverallCoins = 0;

        Globalpoints.Level3Chests = 0;

        Globalpoints.Level3Coins = 0;

        Globalpoints.Level3Score = 0;
    }

    public void ScoreboardResetData()
    {
        Globalkills.Overallkills = 0;

        Globalpoints.OverallChests = 0;

        Globalpoints.OverallCoins = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}