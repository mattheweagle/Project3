using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** Opens final door.
 */
public class open_Door : MonoBehaviour {
    bool doorIsOpen = false;
    private object collision;
    public GameObject Door;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /** will start animation after player collides with exit door indicating level was completed.
     */
    void playerHitsDoor(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(this.gameObject.tag == "Door")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.black;
            }
        }
    }
}
