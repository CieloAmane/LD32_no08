using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public float autoMoveSpeed = 15.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //常に動いている。
        transform.position += transform.forward * autoMoveSpeed * Time.deltaTime;

	}
}
