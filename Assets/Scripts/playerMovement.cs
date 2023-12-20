using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private bool moveRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -2)
        {
            moveRight = true;
        }

        else if (transform.position.x > 2)
        {
            moveRight = false;
        }

        if (moveRight == true)
        {
            transform.position = new Vector2(transform.position.x + .05f, transform.position.y);
        }

        else
        {
            transform.position = new Vector2(transform.position.x - .05f, transform.position.y);
        }
    }
}
