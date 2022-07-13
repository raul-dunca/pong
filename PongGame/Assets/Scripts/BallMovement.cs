using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float MovementSpeed;
    public float ExtraSpeedPerHit;
    public float MaxExtraSpeed;
    int hitCounter = 0;
    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    void PositionBall(bool isStartingPlayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        if (isStartingPlayer1)
        {
            
            gameObject.transform.localPosition = new Vector3(-100, 80, 0);
        }
        else
        {
            
            gameObject.transform.localPosition = new Vector3(100, 80, 0);
        }
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        PositionBall(isStartingPlayer1);
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer1)
            MoveBall(new Vector2(-1, 0));
        else
            MoveBall(new Vector2(1, 0));
    }
    public void MoveBall(Vector2  dir)
    {
        dir = dir.normalized;
        float speed = this.MovementSpeed + this.hitCounter * this.ExtraSpeedPerHit;
        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = dir * speed;
    }

    public void IncreaseHitCounter()
    {
        if (hitCounter*ExtraSpeedPerHit <= MaxExtraSpeed)
           hitCounter++;
    }
}
