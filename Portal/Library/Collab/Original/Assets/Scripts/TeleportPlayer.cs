﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    string portalEntered;

    // pre: portals are created within an appropiate surface
    // post: after player enters a portal it's position changes to that of the other portal
    // This method runs after registering collision of player with portal and its goal is to switch the position of the player to that one of the other portal

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");
        GameObject BluePortal = GameObject.FindWithTag("portal_blue");
        GameObject RedPortal = GameObject.FindWithTag("portal_red");
        if (collision.gameObject.tag == "portal_blue" && !this.GetComponent<PlayerMovement>().isTeleported)
        {
            portalEntered = "blue";
            this.gameObject.transform.position = RedPortal.transform.position;
            this.GetComponent<PlayerMovement>().isTeleported = true;
         
        }
        if (collision.gameObject.tag == "portal_red" && !this.GetComponent<PlayerMovement>().isTeleported)
        {
            portalEntered = "red";
            this.gameObject.transform.position = BluePortal.transform.position;
            this.GetComponent<PlayerMovement>().isTeleported = true;

        }

    }

    // Resets the state of the player after its position is changed between the portals

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "portal_blue" && portalEntered == "red")
        {
            this.GetComponent<PlayerMovement>().isTeleported = false;
        }
        if (collision.gameObject.tag == "portal_red" && portalEntered == "blue")
        {
            this.GetComponent<PlayerMovement>().isTeleported = false;
        }

    }
}