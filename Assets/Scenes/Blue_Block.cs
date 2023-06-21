using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Block : MonoBehaviour
{
    public int blockHealth;
    private MeshRenderer arter;
    public Material blue_break;
    public AudioSource blockSound;
    public void Start()
    {
        arter = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            blockHealth--;
            Win.score += 20;
            blockSound.Play();  
        }

        if (blockHealth == 0)
        {
            Destroy(this.gameObject);
        }

        if (blockHealth == 1)
        {
            arter.material = blue_break;
        }
    }
}
