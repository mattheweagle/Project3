using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** Handles collision of portal bullet with terrain.
 */
public class antiportal : MonoBehaviour {

    /** This method runs when the portal bullet hits a surface generating a collision.
    * @pre portal bullet is shot
    * @post after collision bullet is removed but no portal is created.
    */
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "portal_blue_bullet")
        {

            Destroy(GameObject.FindWithTag("portal_blue_bullet"));
        }
        if (collision.gameObject.tag == "portal_red_bullet")
        {

            Destroy(GameObject.FindWithTag("portal_red_bullet"));
        }
    }



}
