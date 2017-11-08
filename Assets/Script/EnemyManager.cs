using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public GameObject EnemyPaty1;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "EPaty1")
        {
            Instantiate(EnemyPaty1, new Vector3(1.0f, 2.0f, 0.0f), Quaternion.identity);
        }
    }
}
