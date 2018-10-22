using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** Handles portal shooting.
 */
public class ShootPortal : MonoBehaviour {
    public GameObject bluePortal;
    public GameObject redPortal;
    public Vector2 velocity;
	// Use this for initialization
	void Start () {
		
	}

    /** shoots a portal when mouse is clicked following the direction towards the location of the mouse pointer when clicked.
    * @pre mouse is clicked
    * @post portal is shot
    */
    void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject blue_portal_bullet = GameObject.FindWithTag("portal_blue_bullet");
            Destroy(blue_portal_bullet);
            Instantiate(bluePortal, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject red_portal_bullet = GameObject.FindWithTag("portal_red_bullet");
            Destroy(red_portal_bullet);
            Instantiate(redPortal, transform.position, Quaternion.identity);
        }
    }
}
