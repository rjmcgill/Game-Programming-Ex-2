using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject fish;
    public GameObject bomb;
    private float timer = 2;
    private float bombWidth;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        } else
        {
            if(Random.Range(1, 5) == 4)
            {
                GameObject bombObj = Instantiate(bomb, new Vector3(Random.Range(screenBounds.x * -1, screenBounds.x), 6, 0), Quaternion.identity);
            }
            else
            {
                GameObject fishObj = Instantiate(fish, new Vector3(Random.Range(screenBounds.x * -1, screenBounds.x), 6, 0), Quaternion.identity);
            }
            timer = 2;
        }
    }
}
