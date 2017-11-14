using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyPaty : MonoBehaviour {
    public GameObject enemyPaty;
    public Quaternion q = new Quaternion();
	// Use this for initialization
	void Start () {
        Instantiate(enemyPaty, new Vector3(0, 0, transform.position.z + 5.0f), q);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
