using System;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement : MonoBehaviour
{
    private Transform tr;

    public float speed = 3.5f;
    private float init_speed;

    public bool leftWallCol;
    public bool rightWallCol;

    void Start()
    {
        tr = gameObject.GetComponent<Transform>();

        init_speed = speed;
        leftWallCol = false;
        rightWallCol = false;
    }

    // Update is called once per frame
    void Update()
    {
        // GetKey (Each Frame)
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            KeyDown_LeftArrow();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            KeyDown_RightArrow();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            KeyDown_L(true);
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            KeyDown_L(false);
        }
    }

    private void KeyDown_LeftArrow()
    {
        if (!leftWallCol && !Input.GetKey(KeyCode.RightArrow))
        {
            tr.position += Vector3.left * (speed * Time.deltaTime);
        }

    }

    private void KeyDown_RightArrow()
    {
        if (!rightWallCol && !Input.GetKey(KeyCode.LeftArrow))
        {
            tr.position += Vector3.right * (speed * Time.deltaTime);
        }
    }

    private void KeyDown_L(bool fast)
    {
        if (fast)
        {
            speed = init_speed * 2.2f;
        }
        else
        {
            speed = init_speed;
        }
    }
}
