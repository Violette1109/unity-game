using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collect : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private Text scoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("apple"))
        {
            collision.gameObject.SetActive(false);
            score += 5;
            scoreText.text = "Score: " + score;
        }
        if (collision.gameObject.CompareTag("berry"))
        {
            collision.gameObject.SetActive(false);
            score += 10;
            scoreText.text = "Score: " + score;
        }
    }
}
