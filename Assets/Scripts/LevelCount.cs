using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCount : MonoBehaviour
{
    public Text LevelText;

    // Start is called before the first frame update
    void Start()
    {
        LevelText.text = "" + GlobalLevel.LevelCount;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
