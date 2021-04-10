﻿using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode jumpKey;

    public float speed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;

        // "w" can be replaced with any key
        // this section moves the character up
        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
            pos.x += speed * Time.deltaTime;

            /*
            if (pos.y > Screen.height){
                pos.y = Screen.height;
            } else if (pos.y < 0f){
                pos.y = 0f;
            }

            if (pos.x > Screen.width){
                pos.x = Screen.width;
            } else if (pos.x < 0f) {
                pos.x = 0f;
            }
            */
        }

        // "s" can be replaced with any key
        // this section moves the character down
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
            pos.x -= speed * Time.deltaTime;
        }

        // "d" can be replaced with any key
        // this section moves the character right
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
            pos.y -= speed * Time.deltaTime;
        }

        // "a" can be replaced with any key
        // this section moves the character left
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
            pos.y += speed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
