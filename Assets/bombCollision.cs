using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombCollision : MonoBehaviour
{
    bool kaboom = false;
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
        if (collision.gameObject.name == "net")
        {
            FindObjectOfType<Manager>().GameOver();
            kaboom = true;
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "ground")
        {
            Destroy(gameObject);
        }
    }

    public bool GetKaboom()
    {
        return kaboom;
    }
}
