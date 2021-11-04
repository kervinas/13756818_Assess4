using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentMovement1 : MonoBehaviour
{
    Rigidbody2D rigidb2D;
    private float horizontalSpeed = 2.0f;
    private float verticalSpeed = 2.0f;

    public const string RIGHT = "right";
    public const string LEFT = "left";
    public const string UP = "up";
    public const string DOWN = "down";
    string pressKey;


    void Start()
    {
      rigidb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.D) ||  Input.GetKey(KeyCode.RightArrow))
      {
        pressKey = RIGHT;
      }
      else if (Input.GetKey(KeyCode.A) ||  Input.GetKey(KeyCode.LeftArrow))
      {
        pressKey = LEFT;
      }
      else if (Input.GetKey(KeyCode.W) ||  Input.GetKey(KeyCode.UpArrow))
      {
        pressKey = UP;
      }
      else if (Input.GetKey(KeyCode.S) ||  Input.GetKey(KeyCode.DownArrow))
      {
        pressKey = DOWN;
      }
      else
      {
        pressKey = null;
      }
    }

    private void FixedUpdate()
    {
        if(pressKey == RIGHT)
        {
          GetComponent<Rigidbody2D>().velocity = new Vector2 (horizontalSpeed, 0);
        }
        if(pressKey == LEFT)
        {
          GetComponent<Rigidbody2D>().velocity = new Vector2 (-horizontalSpeed, 0);
        }
        if(pressKey == UP)
        {
          GetComponent<Rigidbody2D>().velocity = new Vector2 (0, verticalSpeed);
        }
        if(pressKey == DOWN)
        {
          GetComponent<Rigidbody2D>().velocity = new Vector2 (0, -verticalSpeed);
        }
    }
}
