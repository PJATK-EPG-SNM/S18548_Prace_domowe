using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 300;
    public float jump = 370;
    public bool DeathWater = false;
    public bool Enemy = false;

    private Rigidbody2D rb;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        float xDisplacement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);

        if (Input.GetKeyDown("space") && (isGrounded == true))
        {
            rb.AddForce(new Vector2(0, jump));
            isGrounded = false;
        }

        if (DeathWater || Enemy == true)
        {
           Destroy(gameObject);
            Application.LoadLevel(Application.loadedLevel);
            
        }
    }
    private void OnCollisionEnter2D(Collision2D colision)
    {
        isGrounded = true;
        
        if (colision.gameObject.name == "Water")
        {
            DeathWater = true;
        }
        if (colision.gameObject.name == "Enemy")
       {
            Enemy = true;
        }
    }


}

