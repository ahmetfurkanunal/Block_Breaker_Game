using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject textObject, playerObject, ballObject;
    public TextMeshProUGUI wonText;
    public Transform blocks;
    int blockNumber;
    public static int score;
    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        score = 0;
    }

 
    void Update()
    {

        if (Time.timeScale == 0)
        {

            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }

        scoreText.text = "Score :" + score;
        blockNumber = blocks.childCount;
        
        if(blockNumber == 0)
        {
            wonText.text = "Congrulations!\n Your Score :"+score+ "\n\n Tap to Play!";
            Time.timeScale = 0;
            Destroy(textObject.gameObject);         
            Destroy(playerObject.gameObject);
            Destroy(ballObject.gameObject);

            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
    }
}
