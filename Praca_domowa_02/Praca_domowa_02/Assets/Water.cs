using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject PlayerDie;

    private Rigidbody2D rb;
  

    void Dead()
    {
        Destroy(gameObject);
    }

    void Respawn()
    {
         
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.tag == "Water")
        {
            Dead();
            Respawn();
        }
    }
}
