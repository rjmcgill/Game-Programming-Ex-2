using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
