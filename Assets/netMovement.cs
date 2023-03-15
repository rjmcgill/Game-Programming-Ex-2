using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class netMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 0);
    private Vector2 screenBounds;
    private Vector2 movement;
    private Rigidbody2D rigidComponent;
    private float netWidth;


    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        netWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
    }
    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        movement = new Vector2(speed.x * inputX, 0);
    }

    void FixedUpdate()
    {
        if (rigidComponent == null) rigidComponent = GetComponent<Rigidbody2D>();
        rigidComponent.velocity = movement;
    }

    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + netWidth, screenBounds.x - netWidth);
        transform.position = viewPos;
    }
}
