﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ekmek : MonoBehaviour
{
    private canvaskon canvas;
    private void Start()
    {
        canvas = FindObjectOfType<canvaskon>();

    }






    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            karakterhar Player = collision.gameObject.GetComponent<karakterhar>();
            Player.speedamount += 2f;
            canvas.hızgüncelle();
            

            gameObject.SetActive(false);

        }
    }
}
