using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class life : MonoBehaviour
{
    private int lifenum = 3;
    [SerializeField] private Text lifeText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("saw"))
        {
            if (lifenum > 0)
            {
                --lifenum;
                lifeText.text = "Life: " + lifenum;
            }
            if (lifenum==0)
            {
                Die();
            }
        }
    }

    private void Die()
    {
        SceneManager.LoadScene("SampleScene 3");
    }

}
