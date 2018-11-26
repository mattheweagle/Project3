using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chipAI : MonoBehaviour {

    Transform player;
    float speed = 2f;


    // Use this for initialization
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update() {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        
    }
    
}
