using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollision : MonoBehaviour
{
    public int cnt = 1;
    // public int kind = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cnt <= 0)
        {
            Destroy(gameObject);
        }
    }
}
