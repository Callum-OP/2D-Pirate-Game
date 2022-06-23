using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public Text Totalscore;

    public Text Totaltime;

    public Text Totalkill;

    public Text Totalchest;

    public Text Totalcoin;

    public Text Totalrank;


    // Start is called before the first frame update
    void Start()
    {
        Totalscore.text = GlobalScore.PlayerScore + " score";

        Totaltime.text = GlobalTime.OverallTime + " seconds";

        Totalkill.text = Globalkills.Overallkills + " enemies";

        Totalchest.text = Globalpoints.OverallChests + " chests";

        Totalcoin.text = Globalpoints.OverallCoins + " coins";

        Totalrank.text = Globalrank.OverallPerformance + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
