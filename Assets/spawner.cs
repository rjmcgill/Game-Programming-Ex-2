using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject fish;
    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        GameObject fishObj = Instantiate(fish);
        GameObject bombObj = Instantiate(bomb);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
