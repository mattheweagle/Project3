using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "portal")
        {
            Destroy(collision.gameObject);
            //create portal
        }
    }
}
