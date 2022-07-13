using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionController : MonoBehaviour
{
    public BallMovement ballmovement;
    public ScoreController ScoreController;
    void BounceFromRecket(Collision2D c)
    {
        
        Vector3 ballPosition = this.transform.position;
        Vector3 recketpostion = c.gameObject.transform.position;
        float recketHeight = c.collider.bounds.size.y;
        float x;
        if (c.gameObject.name == "Recket Left")
            x = 1;
        else
            x = -1;
        float y = (ballPosition.y - recketpostion.y) / recketHeight;
        
        this.ballmovement.IncreaseHitCounter();
        this.ballmovement.MoveBall(new Vector2(x, y));
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Recket Left" || collision.gameObject.name == "Recket Right")
        {
            this.BounceFromRecket(collision);

        }
        else if (collision.gameObject.name == "Wall Left")
        {
            this.ScoreController.GoalPlayer2();
            StartCoroutine(this.ballmovement.StartBall(true));
        }
        else if (collision.gameObject.name == "Wall Right")
        {
            this.ScoreController.GoalPlayer1();
            StartCoroutine(this.ballmovement.StartBall(false));
        }
    }
}
