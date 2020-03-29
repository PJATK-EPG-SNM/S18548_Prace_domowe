using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_attach : MonoBehaviour
{
    public GameObject Player;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }
}
