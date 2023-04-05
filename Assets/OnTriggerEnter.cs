using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{
    public MoveMent movement;

    private void Start()
    {
        movement = FindObjectOfType<MoveMent>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Tp")
        {
            movement.Canmove = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag != "Tp")
        {
            movement.Canmove = true;
        }
    }
}
