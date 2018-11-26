using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBox : MonoBehaviour {

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
        GameObject BluePortal = GameObject.FindWithTag("portal_blue");
        GameObject RedPortal = GameObject.FindWithTag("portal_red");
        if (collision.gameObject.tag == "portal_blue" && !this.GetComponent<BoxMovement>().isTeleported)
        {
            //store current speed on entering portal
            this.GetComponent<BoxMovement>().currentSpeed = this.GetComponent<Rigidbody2D>().velocity.magnitude;





            this.gameObject.transform.position = RedPortal.transform.position;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            //this.GetComponent<BoxMovement>().limitspeed = false;
            portalEntered = "blue";
            this.GetComponent<BoxMovement>().isTeleported = true;

            //launch player using current speed in certain direction according to where the exit portal is located
            if (RedPortal.GetComponent<teleporterLocation>().location == "left_wall")
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<BoxMovement>().currentSpeed, 0);
            }
            else if (RedPortal.gameObject.GetComponent<teleporterLocation>().location == "ceiling")
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -this.GetComponent<BoxMovement>().currentSpeed);
            }
            else if (RedPortal.GetComponent<teleporterLocation>().location == "ground")
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, this.GetComponent<BoxMovement>().currentSpeed);
            }
            else
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(-this.GetComponent<BoxMovement>().currentSpeed, 0);
            }

        }
        if (collision.gameObject.tag == "portal_red" && !this.GetComponent<BoxMovement>().isTeleported)
        {
            this.GetComponent<BoxMovement>().currentSpeed = this.GetComponent<Rigidbody2D>().velocity.magnitude;

            this.gameObject.transform.position = BluePortal.transform.position;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

            //this.GetComponent<BoxMovement>().limitspeed = false;
            portalEntered = "red";
            this.GetComponent<BoxMovement>().isTeleported = true;
            if (BluePortal.GetComponent<teleporterLocation>().location == "left_wall")
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<BoxMovement>().currentSpeed, 0);
            }
            else if (BluePortal.GetComponent<teleporterLocation>().location == "ceiling")
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -this.GetComponent<BoxMovement>().currentSpeed);
            }
            else if (BluePortal.GetComponent<teleporterLocation>().location == "ground")
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, this.GetComponent<BoxMovement>().currentSpeed);
            }
            else
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(-this.GetComponent<BoxMovement>().currentSpeed, 0);
            }

        }


    }

    // Resets the state of the player after its position is changed between the portals

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "portal_blue" && portalEntered == "red")
        {
            this.GetComponent<BoxMovement>().isTeleported = false;
        }
        if (collision.gameObject.tag == "portal_red" && portalEntered == "blue")
        {
            this.GetComponent<BoxMovement>().isTeleported = false;
        }

    }
}
