using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    [SerializeField]
    GameObject ButtonPushed;

    [SerializeField]
    GameObject ButtonNotPushed;

    public bool isPushed = false;
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<SpriteRenderer>().sprite = ButtonNotPushed.GetComponent<SpriteRenderer>().sprite;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = ButtonPushed.GetComponent<SpriteRenderer>().sprite;
        isPushed = true;
        Destroy(GameObject.FindGameObjectWithTag("breakable"));
    }
    // Update is called once per frame
    void Update () {
		
	}
}
