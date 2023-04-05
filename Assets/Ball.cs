using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    
    public Rigidbody2D rigidBody2D;
    public float speed = 2.5f;
    public Vector2 velocity;
    public TextMeshProUGUI leftPlayerScoreText;
    public TextMeshProUGUI rightPlayerScoreText;
    private int leftPlayerScore;
    private int rightPlayerScore;

    void Start()
    {
        leftPlayerScore = 0;
        leftPlayerScoreText.text = leftPlayerScore.ToString();
        rightPlayerScore = 0;
        rightPlayerScoreText.text = rightPlayerScore.ToString();
        rigidBody2D = GetComponent<Rigidbody2D>();
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);
        rigidBody2D.velocity = new Vector2(randomX, randomY).normalized * speed;
        velocity = rigidBody2D.velocity;


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidBody2D.velocity = Vector2.Reflect(velocity, collision.contacts[0].normal);
        velocity = rigidBody2D.velocity;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.x > 0)
        {
            leftPlayerScore += 1;
            leftPlayerScoreText.text = leftPlayerScore.ToString();
        }
            
        
        if (transform.position.x < 0)
        {
            rightPlayerScore += 1;
            rightPlayerScoreText.text = rightPlayerScore.ToString();
        }

        rigidBody2D.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);
        rigidBody2D.velocity = new Vector2(randomX, randomY).normalized * speed;
        velocity = rigidBody2D.velocity;
    }
}
