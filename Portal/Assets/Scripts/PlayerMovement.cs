using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** Handles player movement. 
 */
public class PlayerMovement : MonoBehaviour {
    public bool faceRight = true;
    public bool jump = false;
    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 200f;
    public Transform groundCheck; // to allow character to stay up when in contact with "Ground" materials
    public bool isTeleported = false;
    private bool grounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;


    /** Runs at start. 
     * @pre game starts
     * @post Animator object and Rigidbody object get initialized for the player
     */
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    /** Checks state of player every frame.
     *  @pre none
     *  @post State of player gets changed depending on what was pressed
     */
    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (Input.GetButtonDown("Jump") && grounded)
        {
            jump = true;
        }
    }

    /** Method is in charge of limiting the players moving speed and changing jump state if button is pressed.
     *  @pre Update() ran
     *  @post Movement of player is limited to our constraints
     */
    void FixedUpdate()
    {
        float dir = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(dir));

        if (dir * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * dir * moveForce); //increases speed to maxSpeed

        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y); // limits the velocity of the character to maxSpeed but keeps the direction

        if (dir > 0 && !faceRight)
            DirectionSwitch();
        else if (dir < 0 && faceRight)
            DirectionSwitch();

        if (jump) //if space bar pressed = jumps
        {
            anim.SetTrigger("Jump");
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
    }

    /** Changes character direction.
     *  function is called by FixedUpdate() when user is switching direction of player
     *  @pre User is pressing the left key
     *  @post Changes direction of the player if the left key is pressed
     */
    void DirectionSwitch()
    {
        faceRight = !faceRight; //switches directions
        Vector3 theScale = transform.localScale;
        transform.localScale = theScale;
    }
}
