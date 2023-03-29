using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    public Rigidbody2D rigidBody2D;
    public KeyCode upKey;
    public KeyCode downKey;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(upKey) && transform.position.y < 5)
        {
            rigidBody2D.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(downKey) && transform.position.y > -5)
        {
            rigidBody2D.velocity = Vector2.down * speed;
        }
        else 
        {
            rigidBody2D.velocity = Vector2.zero;
        }


    }


}
