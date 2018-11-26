using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {
    public GameObject bluePortal;
    public GameObject redPortal;
    public GameObject Portal;
    public GameObject NewPortal;

    // pre: portal bullet is shot
    // post: after collision with appropriate surface portal gets created and previous portal gets destroyed
    // This method runs when the portal bullet hits a surface generating a collision

    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "portal_blue_bullet")
        {
            Portal = GameObject.FindWithTag("portal_blue");
            Destroy(Portal);
            NewPortal = Instantiate(bluePortal, collision.transform.position, Quaternion.identity);
            
            if (this.tag == "ceiling")
            {
                NewPortal.transform.Translate(0, -.33f, 0);
                NewPortal.transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
            }
            else if(this.tag == "right_wall")
            {
                NewPortal.transform.Translate(-0.33f, 0, 0);
                NewPortal.transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
            }
            else if(this.tag == "ground")
            {
                NewPortal.transform.Translate(0, 0.33f, 0);
                NewPortal.transform.rotation = Quaternion.AngleAxis(270, Vector3.forward);
            }
            else
            {
                NewPortal.transform.Translate(0.33f, 0, 0);
            }

            
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "portal_red_bullet")
        {
            Portal = GameObject.FindWithTag("portal_red");
            Destroy(Portal);
            NewPortal = Instantiate(redPortal, collision.transform.position, Quaternion.identity);

            if (this.tag == "ceiling")
            {
                NewPortal.transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
            }
            else if (this.tag == "right_wall")
            {
                NewPortal.transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
            }
            else if (this.tag == "ground")
            {
                NewPortal.transform.Translate(0, 0.33f, 0);
                NewPortal.transform.rotation = Quaternion.AngleAxis(270, Vector3.forward);
            }
            Destroy(collision.gameObject);
        }
        //create portal

    }



}
