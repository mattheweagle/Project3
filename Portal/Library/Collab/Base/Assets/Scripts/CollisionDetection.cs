using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {
    public GameObject bluePortal;
    public GameObject redPortal;
    public GameObject Portal;

    // pre: portal bullet is shot
    // post: after collision with appropriate surface portal gets created and previous portal gets destroyed
    // This method runs when the portal bullet hits a surface generating a collision

    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "portal_blue_bullet")
        {
            Portal = GameObject.FindWithTag("portal_blue");
            Destroy(Portal);
            Instantiate(bluePortal, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "portal_red_bullet")
        {
            Portal = GameObject.FindWithTag("portal_red");
            Destroy(Portal);
            Instantiate(redPortal, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
        //create portal

    }
}
