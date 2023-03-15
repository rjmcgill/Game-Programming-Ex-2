using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class finalScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    void Start()
    {
        scoreText.text = "Final Score: " + staticScore.score;
    }
}
