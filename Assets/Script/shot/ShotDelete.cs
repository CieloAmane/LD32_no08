﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotDelete : MonoBehaviour {

    public GameObject Pshot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "enemy")
        {
            Debug.Log("エネミーと当たった。");
            Destroy(Pshot);
        }
    }
}
