using UnityEngine;
using System.Collections;

public static class Globalpoints
{
    public static int OverallChests = 0;

    public static int OverallCoins = 0;

    public static int Level1Coins = 0;

    public static int Level1Chests = 0;

    public static int Level2Coins = 0;

    public static int Level2Chests = 0;

    public static int Level3Coins = 0;

    public static int Level3Chests = 0;

    public static int Level1Score = 0;

    public static int Level2Score = 0;

    public static int Level3Score = 0;

}

[AddComponentMenu("Playground/Attributes/Collectable")]
public class CollectableAttribute : MonoBehaviour
{
	public int pointsWorth = 1;
	
	private UIScript userInterface;

	private void Start()
	{
		// Find the UI in the scene and store a reference for later use
		userInterface = GameObject.FindObjectOfType<UIScript>();
	}


	//This will create a dialog window asking for which dialog to add
	private void Reset()
	{
		Utils.Collider2DDialogWindow(this.gameObject, true);
	}


	// This function gets called everytime this object collides with another
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string playerTag = otherCollider.gameObject.tag;

		// is the other object a player?
		if(playerTag == "Player" || playerTag == "Player2")
		{
			if(userInterface != null)
			{
				// add one point
				int playerId = (playerTag == "Player") ? 0 : 1;
				userInterface.AddPoints(playerId, pointsWorth);
			}

			// then destroy this object
			Destroy(gameObject);

            if (pointsWorth == 100)
            {
                Globalpoints.OverallChests = Globalpoints.OverallChests + 1;

                if (GlobalLevel.LevelCount == 1)
                {
                    Globalpoints.Level1Chests = Globalpoints.Level1Chests + 1;
                    Globalpoints.Level1Score = Globalpoints.Level1Score + 100;
}
                else if (GlobalLevel.LevelCount == 2)
                {
                    Globalpoints.Level2Chests = Globalpoints.Level2Chests + 1;
                    Globalpoints.Level2Score = Globalpoints.Level2Score + 100;
                }
                if (GlobalLevel.LevelCount == 3)
                {
                    Globalpoints.Level3Chests = Globalpoints.Level3Chests + 1;
                    Globalpoints.Level3Score = Globalpoints.Level3Score + 100;
                }

            }
            else if (pointsWorth == 25)
            {
                Globalpoints.OverallCoins = Globalpoints.OverallCoins + 1;

                if (GlobalLevel.LevelCount == 1)
                {
                    Globalpoints.Level1Coins = Globalpoints.Level1Coins + 1;
                    Globalpoints.Level1Score = Globalpoints.Level1Score + 25;
                }
                else if (GlobalLevel.LevelCount == 2)
                {
                    Globalpoints.Level2Coins = Globalpoints.Level2Coins + 1;
                    Globalpoints.Level2Score = Globalpoints.Level2Score + 25;
                }
                else if (GlobalLevel.LevelCount == 3)
                {
                    Globalpoints.Level3Coins = Globalpoints.Level3Coins + 1;
                    Globalpoints.Level3Score = Globalpoints.Level3Score + 25;
                }
            }

        }
	}
}
