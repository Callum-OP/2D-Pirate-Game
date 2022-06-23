using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // allows for scene management

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1"); //Locate and load scene called Level 1
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("Main Menu"); //Locate and load scene called Level 1
    }

    public void HelpForm()
    {
        SceneManager.LoadScene("Help Scene"); //Locate and load scene called Level 1
    }

    public void NextLevel1()
    {
        SceneManager.LoadScene("Level 2"); //Locate and load the next scene
    }

    public void RestartLevel1()
    {
        SceneManager.LoadScene("Level 1"); //Locate and load current level scene
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
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
