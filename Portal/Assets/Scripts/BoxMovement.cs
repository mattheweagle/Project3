using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour {
    public bool limitspeed = true;
    public bool isTeleported = false;
    private bool grounded = false;
    //public Transform groundCheck;
    public float currentSpeed = 0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (grounded)
        {
            limitspeed = true;
        }
    }
}
