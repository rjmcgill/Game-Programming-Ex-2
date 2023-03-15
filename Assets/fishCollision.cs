using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fishCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) 
    { 
        if(collision.gameObject.name == "net") {
            FindObjectOfType<score>().IncrementScore();
            Destroy(gameObject);
        }
        if(collision.gameObject.name == "ground")
        {
            Destroy(gameObject);
        }
    }
}
