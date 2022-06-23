using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreboard : MonoBehaviour
{
    public Text Totalscore;

    public Text Totalkill;

    public Text Totalchest;

    public Text Totalcoin;

    public Text Totalrank;

    private int GamePerformance;


    // Start is called before the first frame update
    void Start()
    {
        Totalscore.text = Globalpoints.Level1Score + Globalpoints.Level2Score + Globalpoints.Level3Score + " score";

        Totalkill.text = Globalkills.Level1kills + Globalkills.Level2kills + Globalkills.Level3kills + " enemies";

        Totalchest.text = Globalpoints.Level1Chests + Globalpoints.Level2Chests + Globalpoints.Level3Chests + " chests";

        Totalcoin.text = Globalpoints.Level1Coins + Globalpoints.Level2Coins + Globalpoints.Level3Coins + " coins";

        if (Globalpoints.Level1Score + Globalpoints.Level2Score + Globalpoints.Level3Score >= 3250 && (Globalkills.Level1kills + Globalkills.Level2kills + Globalkills.Level3kills < 20))
        {
            Totalrank.text = "Well done " + Name.username + " you are the richest pirate!";
        }
        else if (Globalkills.Level1kills + Globalkills.Level2kills + Globalkills.Level3kills >= 20 && Globalpoints.Level1Score + Globalpoints.Level2Score + Globalpoints.Level3Score < 3250)
        {
            Totalrank.text = Name.username + " you are the most feared pirate!";
        }
        else if (Globalpoints.Level1Score + Globalpoints.Level2Score + Globalkills.Level1kills + Globalkills.Level2kills + Globalkills.Level3kills > 20 && Globalpoints.Level1Score + Globalpoints.Level2Score + Globalpoints.Level3Score > 3250)
        {
            Totalrank.text = "Well done " + Name.username + " you are the greatest pirate!";
        }
        else
        {
            Totalrank.text = "Well done " + Name.username + " you completed the game!";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
