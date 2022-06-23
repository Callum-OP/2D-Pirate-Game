using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[AddComponentMenu("Playground/Attributes/Health System")]
public class HealthSystemAttribute : MonoBehaviour
{
    public int health = 3;

    private UIScript ui;
    private int maxHealth;

    // Will be set to 0 or 1 depending on how the GameObject is tagged
    // it's -1 if the object is not a player
    private int playerNumber;



    private void Start()
    {
        // Find the UI in the scene and store a reference for later use
        ui = GameObject.FindObjectOfType<UIScript>();

        // Set the player number based on the GameObject tag
        switch (gameObject.tag)
        {
            case "Player":
                playerNumber = 0;
                break;
            case "Player2":
                playerNumber = 1;
                break;
            default:
                playerNumber = -1;
                break;
        }

        // Notify the UI so it will show the right initial amount
        if (ui != null
            && playerNumber != -1)
        {
            ui.SetHealth(health, playerNumber);
        }

        maxHealth = health; //note down the maximum health to avoid going over it when the player gets healed
    }


    // changes the energy from the player
    // also notifies the UI (if present)
    public void ModifyHealth(int amount)
    {
        //avoid going over the maximum health by forcin
        if (health + amount > maxHealth)
        {
            amount = maxHealth - health;
        }

        health += amount;

        // Notify the UI so it will change the number in the corner
        if (ui != null
            && playerNumber != -1)
        {
            ui.ChangeHealth(amount, playerNumber);
        }
    }

    void Update() // Update is called once per frame
    {
        if (health <= 0)
        {
            if (GlobalLevel.LevelCount == 1)
            {
                Destroy(gameObject); //destroy character
                SceneManager.LoadScene("L1 Death Scene"); //load death scene
            }
            else if (GlobalLevel.LevelCount == 2)
            {
                Destroy(gameObject); //destroy character
                SceneManager.LoadScene("L2 Death Scene"); //load death scene
            }
            else if (GlobalLevel.LevelCount == 3)
            {
                Destroy(gameObject); //destroy character
                SceneManager.LoadScene("L3 Death Scene"); //load death scene
            }

        }
    }
}