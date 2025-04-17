using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rb = null;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 force2D = Vector2.zero;

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0,0);
        }
        if (Input.GetKeyDown("space"))
        {
            rb.linearVelocity = new Vector2(0, 15);
        }

        rb.AddForce(force2D);
    }

    
}
