using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void Start()
    {
        SceneManager.UnloadSceneAsync("GameOverScene");
    }
    public void GameOver()
    {
        Debug.Log("Game over");
        SceneManager.LoadScene("GameOverScene");
    }
}
