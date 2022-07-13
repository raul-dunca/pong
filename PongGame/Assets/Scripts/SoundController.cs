using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource ColissionSound;
    public AudioSource GoalSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Wall Left" || collision.gameObject.name == "Wall Right")
        {
            this.GoalSound.Play();
        }
        else
        {
            this.ColissionSound.Play();
        }
    }
}
