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
        var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject portal = (GameObject) Instantiate(bluePortal, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject portal = (GameObject)Instantiate(redPortal, transform.position, Quaternion.identity);
        }
    }
}
