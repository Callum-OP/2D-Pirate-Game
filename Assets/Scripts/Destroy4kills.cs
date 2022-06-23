using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globalkills
{
    public static int Overallkills = 0;

    public static int Level1kills = 0;

    public static int Level2kills = 0;

    public static int Level3kills = 0;
}

public class Destroy4kills : MonoBehaviour
{
    private UIScript userInterface;

    private void Start()
    {
        // Find the UI in the scene and store a reference for later use
        userInterface = GameObject.FindObjectOfType<UIScript>();
    }

    private void Update()
    {
        
    }

    //This will create a dialog window asking for which dialog to add
    private void Reset()
    {
        Utils.Collider2DDialogWindow(this.gameObject, false);
    }

    //duplication of the following function to accomodate both trigger and non-trigger Colliders
    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        OnTriggerEnter2D(collisionData.collider);
    }

    // This function gets called everytime this object collides with another trigger
    private void OnTriggerEnter2D(Collider2D collisionData)
    {
        // is the other object a Bullet?
        if (collisionData.gameObject.CompareTag("Bullet"))
        {
            // then destroy this object
            Destroy(gameObject);

            //count kill
            Globalkills.Overallkills = Globalkills.Overallkills + 1;

            if (GlobalLevel.LevelCount == 1)
                Globalkills.Level1kills = Globalkills.Level1kills + 1;
            else if (GlobalLevel.LevelCount == 2)
                Globalkills.Level2kills = Globalkills.Level2kills + 1;
            else if (GlobalLevel.LevelCount == 3)
                Globalkills.Level3kills = Globalkills.Level3kills + 1;
        }
    }
}

