using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // allows for scene management
using UnityEngine.UI;

public class FinalUI : MonoBehaviour
{

    public void RestartLevelScoreboard()
    {
        SceneManager.LoadScene("Main Menu"); //Locate and load current level scene
    }

    public void ResetData()
    {
        Globalkills.Overallkills = 0;

        Globalkills.Level1kills = 0;

        Globalkills.Level2kills = 0;

        Globalkills.Level3kills = 0;

        Globalpoints.OverallChests = 0;

        Globalpoints.OverallCoins = 0;

        Globalpoints.Level1Chests = 0;

        Globalpoints.Level1Coins = 0;

        Globalpoints.Level1Score = 0;

        Globalpoints.Level2Chests = 0;

        Globalpoints.Level2Coins = 0;

        Globalpoints.Level2Score = 0;

        Globalpoints.Level3Chests = 0;

        Globalpoints.Level3Coins = 0;

        Globalpoints.Level3Score = 0;

        GlobalLevel.LevelCount = 1;
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
