using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    private int scoreVal;
    public TMP_Text scoreText;
    void Start()
    {
        staticScore.score = 0;
        scoreVal = staticScore.score;
        scoreText.text = "Score: " + scoreVal;
    }

    public void IncrementScore()
    {
        scoreVal = scoreVal + 100;
        staticScore.score = scoreVal;
        scoreText.text = "Score: " + scoreVal;
        Debug.Log(staticScore.score);
    }
}
