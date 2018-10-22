using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour {

    public GameObject youWin;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //After Player "collides" with door object it will display a Win message indicating level completion
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "door" )
        {
            youWin.SetActive (true);
            GameManager.instance.Win();

        }

    }
}
