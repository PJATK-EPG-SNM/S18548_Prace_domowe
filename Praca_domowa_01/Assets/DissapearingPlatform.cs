﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(TimeToWait());
    }

    IEnumerator TimeToWait()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
