using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(main.keyA))
        {
            rb.velocity += new Vector2(-1*speed, 0);
        }
        if (Input.GetKey(main.keyD))
        {
            rb.velocity += new Vector2(1 * speed, 0);
        }
        if (Input.GetKeyDown(main.keyW) || Input.GetKey(main.keyJump))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }

    }
}
