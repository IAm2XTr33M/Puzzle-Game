using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    Vector3 move;

    public float speed;
    public bool Canmove = true;

    void Update()
    {
        if (Canmove)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Canmove = false;
                move = new Vector2(0, -speed);
                transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Canmove = false;
                move = new Vector2(0, speed);
                transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Canmove = false;
                move = new Vector2(-speed, 0);
                transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Canmove = false;
                move = new Vector2(speed, 0);
                transform.localEulerAngles = new Vector3(0, 0, -90);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            Canmove = true;
        }
    }

    private void FixedUpdate()
    {
        transform.position += move * Time.deltaTime;
    }
}
