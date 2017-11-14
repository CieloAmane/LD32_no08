using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDelete : MonoBehaviour {

    public GameObject enemyObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "playerShot")
        {
            Debug.Log("弾と当たった。");
            Destroy(enemyObj);
        }
    }
}

