using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour {

    public GameObject youWin;
  
    /** pre: Player reaches the door object
     *  post: Success message is displayed indicating level completed
     *  After Player "collides" with door object it will display a Win message indicating level completion
     */
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "door" )
        {
            youWin.SetActive (true);
            GameManager.instance.Win();

        }

    }
}
