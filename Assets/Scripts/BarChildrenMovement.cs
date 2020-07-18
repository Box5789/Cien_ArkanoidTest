using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarChildrenMovement : MonoBehaviour
{
    private Transform tr;
    private Transform parentTr;

    // Start is called before the first frame update
    void Start()
    {
        tr = gameObject.GetComponent<Transform>();
        tr.rotation = Quaternion.Euler(0, 0, 0);
        parentTr = tr.parent.gameObject.GetComponent<Transform>();

        tr.position = parentTr.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            if (parentTr.position.x < 0f)
            {
                tr.parent.gameObject.GetComponent<BarMovement>().leftWallCol = true;
            }
            else
            {
                tr.parent.gameObject.GetComponent<BarMovement>().rightWallCol = true;
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            tr.parent.gameObject.GetComponent<BarMovement>().leftWallCol = false;
            tr.parent.gameObject.GetComponent<BarMovement>().rightWallCol = false;
        }
    }
}