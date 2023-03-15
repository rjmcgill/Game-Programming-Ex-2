using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "net")
        {
            FindObjectOfType<Manager>().GameOver();
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "ground")
        {
            Destroy(gameObject);
        }
    }
}
