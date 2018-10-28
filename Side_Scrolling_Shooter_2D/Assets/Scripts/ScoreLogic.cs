using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{
    Text txt;
    public int score = 0;

    private void Start()
    {
        txt = GetComponent<Text>();
    }

    public void AddToScoreVOID()
    {
        score = score + 1;
        PrintScore();
    }

    public void PrintScore()
    {
        txt.text = "Score: " + score;
    }

}// main class
