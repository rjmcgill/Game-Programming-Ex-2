using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    private int scoreVal;
    // Start is called before the first frame update
    public TMP_Text scoreText;
    void Start()
    {
        scoreVal = 0;
        scoreText.text = "Score: " + scoreVal;
    }

    public void IncrementScore()
    {
        scoreVal = scoreVal + 100;
        scoreText.text = "Score: " + scoreVal;
    }
}
