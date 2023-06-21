using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Block : MonoBehaviour
{
    public int blockHealth;
    public AudioSource blockSound;
   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            blockHealth--;
            Win.score += 10;
            blockSound.Play();
        }

        if (blockHealth == 0)
        {
            Destroy(this.gameObject);
        }
    }

}

