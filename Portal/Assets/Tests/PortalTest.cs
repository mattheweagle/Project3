using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PortalTest : MonoBehaviour {

    public Transform[] walls;
    int index;
    public GameObject bluePortal;
    public GameObject redPortal;
 

// Use this for initialization
void Start () {
        index = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
        var direction = walls[index].position;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        if (index == 0) {
            GameObject blue_portal_bullet = GameObject.FindWithTag("testbullet");
            //Destroy(blue_portal_bullet);
            Instantiate(bluePortal, transform.position, Quaternion.identity);
            index++;
        }
        else if(index == 1)
        {
            GameObject blue_portal_bullet = GameObject.FindWithTag("testbullet2");
            //Destroy(blue_portal_bullet);
            Instantiate(redPortal, transform.position, Quaternion.identity);
            index++;
        }
        else
        {
            //Application.Quit();
        }

        
    }
}
