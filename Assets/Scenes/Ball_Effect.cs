using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Ball_Effect : MonoBehaviour
{
    
    public Rigidbody2D ball;
    public float horizontalSpeed , verticalSpeed ;
    public GameObject textObject, playerObject;
    public TextMeshProUGUI scoreText, wonText;

    void Start()
    {
        ball.velocity = new Vector2(Random.Range(-horizontalSpeed, horizontalSpeed), ball.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ball.velocity = new Vector2(ball.velocity.x, verticalSpeed);
        }

        if(collision.gameObject.tag == "Wall-Right")
        {
            ball.velocity = new Vector2(-horizontalSpeed, ball.velocity.y);
        }

        if (collision.gameObject.tag == "Wall_Left")
        {
            ball.velocity = new Vector2(horizontalSpeed, ball.velocity.y);
        }

        if (collision.gameObject.tag == "Wall_Top")
        {
            ball.velocity = new Vector2(ball.velocity.x,-verticalSpeed);
        }

        if (collision.gameObject.tag == "Finish")
        {
            wonText.text = "You Lose!\n Your Score :" +Win.score + "\n\n Tap to Play!";
            Time.timeScale = 0;
            Destroy(textObject.gameObject);        
            Destroy(playerObject.gameObject);
           
        }
    }

}
