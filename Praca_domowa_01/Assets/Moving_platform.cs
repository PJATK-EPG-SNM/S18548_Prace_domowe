using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_platform : MonoBehaviour
{
    public float speed = 1;

    private bool moveRight;

    // Start is called before the first frame update
    void Start()
    {
        moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 2)
            moveRight = false;
        if (transform.position.x < -1)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
    }
}
