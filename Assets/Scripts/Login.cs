using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class Name
{
    public static string username;
}

public class Login : MonoBehaviour
{

    private bool AName = false;

    public void OpenMenu()
    {
        if (AName == true)
        SceneManager.LoadScene("Main Menu"); //Locate and load scene called Main Menu
    }

    public void NameTrue()
    {
        AName = true;
    }

    public void OnString_PlayerName(string value)
    {
        Name.username = value;
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
