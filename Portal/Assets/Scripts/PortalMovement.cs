using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMovement : MonoBehaviour {
    public Vector2 target;
    Rigidbody2D rb;
    public float speed = 30f;
    Vector2 moveDirection;

	// Use this for initialization
    // pre: portal is shot
    // post: portal bullet moves to the location of the mouse when it was clicked until it collides with a valid object
    // Method is in charge of the portal bullet movement 
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        moveDirection.x = target.x - transform.position.x;
        moveDirection.y = target.y - transform.position.y;
        moveDirection = (moveDirection).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
