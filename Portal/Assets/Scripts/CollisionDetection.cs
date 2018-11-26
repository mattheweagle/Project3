using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** Handles collision of portal bullet with terrain.
 */
public class CollisionDetection : MonoBehaviour {
    public GameObject bluePortal;
    public GameObject redPortal;
    public GameObject Portal;
    public GameObject NewPortal;

    /** This method runs when the portal bullet hits a surface generating a collision.
    * @pre portal bullet is shot
    * @post after collision with appropriate surface portal gets created and previous portal gets destroyed
    */
    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "portal_blue_bullet")
        {
            
            Destroy(GameObject.FindWithTag("portal_blue"));
            NewPortal = Instantiate(bluePortal, collision.transform.position, Quaternion.identity);
            
            if (this.tag == "ceiling")
            {
                NewPortal.transform.Translate(0, -.33f, 0);
                NewPortal.transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
                NewPortal.GetComponent<teleporterLocation>().location = "ceiling";
            }
            else if(this.tag == "right_wall")
            {
                NewPortal.transform.Translate(-0.33f, 0, 0);
                NewPortal.transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
                NewPortal.GetComponent<teleporterLocation>().location = "right_wall";
            }
            else if(this.tag == "ground")
            {
                NewPortal.transform.Translate(0, 0.33f, 0);
                NewPortal.transform.rotation = Quaternion.AngleAxis(270, Vector3.forward);
                NewPortal.GetComponent<teleporterLocation>().location = "ground";
            }
            else
            {
                NewPortal.transform.Translate(0.33f, 0, 0);
                NewPortal.GetComponent<teleporterLocation>().location = "left_wall";
            }

            
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "portal_red_bullet")
        {
            Destroy(GameObject.FindWithTag("portal_red"));
            NewPortal = Instantiate(redPortal, collision.transform.position, Quaternion.identity);

            if (this.tag == "ceiling")
            {
                NewPortal.transform.Translate(0, -0.33f, 0);
                NewPortal.transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
                NewPortal.GetComponent<teleporterLocation>().location = "ceiling";
            }
            else if (this.tag == "right_wall")
            {
                NewPortal.transform.Translate(-0.33f, 0, 0);
                NewPortal.transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
                NewPortal.GetComponent<teleporterLocation>().location = "right_wall";
            }
            else if (this.tag == "ground")
            {
                NewPortal.transform.Translate(0, 0.33f, 0);
                NewPortal.transform.rotation = Quaternion.AngleAxis(270, Vector3.forward);
                NewPortal.GetComponent<teleporterLocation>().location = "ground";
            }
            else
            {
                NewPortal.transform.Translate(0.33f, 0, 0);
                NewPortal.GetComponent<teleporterLocation>().location = "left_wall";
            }
            Destroy(collision.gameObject);
        }
        //create portal

    }



}
