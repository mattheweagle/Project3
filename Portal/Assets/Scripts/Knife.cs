using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour {

    public Transform[] patrolpts;
    float speed = 0.15f;
    Transform currentpt;
    int index;


	// Use this for initialization
	void Start () {
        index = 0;
        currentpt = patrolpts[index];
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, patrolpts[index].position, speed);
        //transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (Vector2.Distance(transform.position, currentpt.position)<=.1f)
        {
            if(index+1 < patrolpts.Length)
            {
                
                index++;
            }
            else
            {
                index = 0;
            }
            currentpt = patrolpts[index];
            
        }

        //Vector2 dir = currentpt.position - transform.position;
        //float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //Quaternion q = Quaternion.AngleAxis(angle, Vector2.left);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation,q,180f);

    }
}
