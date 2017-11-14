using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStage : MonoBehaviour {

    public GameObject playerObj;
    public float destroyPosition = 50.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (playerObj.transform.position.z >= (this.gameObject.transform.position.z + destroyPosition))
        {
            Debug.Log("プレイヤーの位置情報を確認、その後デストロイ。");
            Destroy(this.gameObject);
        }

	}
}
