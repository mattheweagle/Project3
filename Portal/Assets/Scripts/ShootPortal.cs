using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPortal : MonoBehaviour {

    public GameObject bluePortal;
    public GameObject redPortal;
    public Vector2 velocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bluePortal, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(redPortal, transform.position, Quaternion.identity);
        }
    }
}
