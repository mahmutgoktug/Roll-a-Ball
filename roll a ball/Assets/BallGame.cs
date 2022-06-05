using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallGame : MonoBehaviour
{
    [HideInInspector]
    public int score;

    public Text ScoreText;

    private void Update()
    {
        ScoreText.text = "Point: " + score.ToString();
    }

}
