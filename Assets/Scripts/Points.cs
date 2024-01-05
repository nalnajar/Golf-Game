using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{

    public Text ScoreText;

    int points = 0;

    public void IncreaseScore()
    {
        points++;
        ScoreText.text = "Strokes: " + points;
    }

    public void ResetScore() 
    {
        points = 0;
        ScoreText.text = "Strokes: " + points;
    }





}
