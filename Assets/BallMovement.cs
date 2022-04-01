using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        LaunchBall();

    }

    private void LaunchBall()
    {
        float x = Random.Range(-1,2);
        float y = Random.Range(-1,2);
        rb.velocity = new Vector2(speed *x,speed *y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LeftWall")
        {
            score.Score1Calculator(1);
        }
        else if (collision.gameObject.tag == "RightWall")
        {
            score.Score2Calculator(1);
        }
    }
}
