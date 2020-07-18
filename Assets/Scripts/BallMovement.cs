using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Transform tr;
    private Vector3 vel;

    public float speed = 3f;
    private float init_speed;

    // Start is called before the first frame update
    void Start()
    {
        tr = gameObject.GetComponent<Transform>();
        vel = new Vector3(-Mathf.Sqrt(speed), -Mathf.Sqrt(speed));

        init_speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        tr.position += vel * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Wall
        if (collision.tag == "Wall")
        {
            vel.x = -vel.x;
            vel *= 1.05f;
        }
        if (collision.tag == "TopWall")
        {
            vel.y = -vel.y;
        }

        // Bar
        if (collision.tag == "TBBar")
        {
            vel.y = -vel.y;
        }
        if (collision.tag == "LRBar")
        {
            vel.x = -vel.x;
        }
        if (collision.tag == "CBar")
        {
            vel.x = -vel.x;
            vel.y = -vel.y;
        }

        // Box
        if (collision.tag == "TBBox")
        {
            vel.y = -vel.y;
        }
        if (collision.tag == "LRBox")
        {
            vel.x = -vel.x;
        }
        if (collision.tag == "CBox")
        {
            vel.x = -vel.x;
            vel.y = -vel.y;
        }
    }
}
