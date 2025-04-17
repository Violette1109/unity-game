using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int waypointIndex = 0;

    [SerializeField] private float speed = 2.5f;

    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        if (Vector2.Distance(waypoints[waypointIndex].transform.position, transform.position) < .1f)
        {
            waypointIndex++;
            if (waypointIndex >= waypoints.Length)
            {
                waypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, Time.deltaTime * speed);

        anim.SetBool("run", horizontalInput !=0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }
    private void OncollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }

}
