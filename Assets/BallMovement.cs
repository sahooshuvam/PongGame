using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public ScoreManager score;
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        transform.position = startPosition;
        LaunchBall();

    }

    public void RestartPosition()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
        LaunchBall();
    }

    private void LaunchBall()
    {
        float x = Random.Range(-1,2);
        float y = Random.Range(-1,2);
        if (x == 0)
            x = -1;
        else if (y == 0)
            y = -1;

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
