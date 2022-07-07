using System; //   .
//   using System.Threading;
//  using System.Threading.Tasks.Dataflow;
//  using System.Reflection.Metadata.Ecma335;
// using System.Reflection.Metadata;
// using Microsoft.CSharp.RuntimeBinder;
// using System.ComponentModel.DataAnnotations.Schema;
//using System.Numerics;
//using Microsoft.CSharp.RuntimeBinder;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float moveInput;
    private Rigidbody2D rb;
    public KeyCode moveRight;
    public KeyCode moveLeft;
    public KeyCode moveJump;
    private bool LookRight = true;
    public float health;
    public float defaultHealth;
    public Vector2 spawnpointPos;
    public float damageCD;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int jumpCount;
    public int jumpNumber;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(moveJump))
        {
            rb.velocity = Vector2.up * jumpForce;
            jumpCount--;

        }
        if (damageCD > 0)
        {
            damageCD -= Time.deltaTime;
        }
        if (isGrounded == true)
        {
            jumpCount = jumpNumber;
        }
    }
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (LookRight == false && moveInput > 0)
        {
            FlipIt();
        }
        else if (LookRight == true && moveInput < 0)
        {
            FlipIt();
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);





    }
    private void FlipIt()
    {
        LookRight = !LookRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
