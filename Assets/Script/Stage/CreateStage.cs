using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStage : MonoBehaviour {

    public GameObject stageObj;
    public GameObject playerObj;
    public Vector3 basePosStage1 = new Vector3(0, 0, 0);
    public Quaternion q = new Quaternion();


    public float createStagePosition = 30.0f;
    public float newStagePosition = 25.0f;
    public float destroyPosition = 50.0f;

    public bool createFlg = false;


	// Use this for initialization
	void Start () {
        playerObj = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(playerObj.transform.position.z >= this.gameObject.transform.position.z + createStagePosition && !createFlg)
        {
            Debug.Log("NextStage生成");
            //ずらした新しい位置にステージを生成。
            Instantiate(stageObj,new Vector3(0,0,this.gameObject.transform.position.z + newStagePosition),q);
            createFlg = true;
        }

        if (playerObj.transform.position.z >= (this.gameObject.transform.position.z + destroyPosition))
        {
            Debug.Log("プレイヤーの位置情報を確認、その後デストロイ。");
            Destroy(this.gameObject);
        }
	}

    //void OnTriggerExit(Collider col)
    //{
    //    //一回しか通らないようにフラグをチェック
    //    flg = true;
    //    Debug.Log("衝突判定成功");
    //    if (flg && col.gameObject.tag == "Player")
    //    {
    //        flg = false;        //入ったからフラグをオフ
    //        Instantiate(stageObj);
    //    }
    //}
}
