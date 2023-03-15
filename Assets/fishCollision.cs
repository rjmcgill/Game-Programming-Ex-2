using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fishCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
