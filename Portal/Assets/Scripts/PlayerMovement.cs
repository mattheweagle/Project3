using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public bool faceRight = true;
    public bool jump = false;
    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 1000f;
    public Transform groundCheck; // to allow character to stay up when in contact with "Ground" materials


    private bool grounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // called every frame
    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (Input.GetButtonDown("Jump") && grounded)
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(h));

        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * moveForce); //increases speed to maxSpeed

        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y); // limits the velocity of the character to maxSpeed but keeps the direction

        if (h > 0 && !faceRight)
            DirectionSwitch();
        else if (h < 0 && faceRight)
            DirectionSwitch();

        if (jump) //if space bar pressed = jumps
        {
            anim.SetTrigger("Jump");
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
    }



    void DirectionSwitch()
    {
        faceRight = !faceRight; //switches directions
        Vector3 theScale = transform.localScale;
        //theScale.x *= -1;
        transform.localScale = theScale;
    }
}
