using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

    public float speed = 10.0f;
    public float autoMoveSpeed = 15.0f;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //常に動いている。
        transform.position += transform.forward * autoMoveSpeed * Time.deltaTime;

        if (Input.GetKey("right"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position -= transform.forward* speed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("up"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
	}
}
