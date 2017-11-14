using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyPaty1 : MonoBehaviour {

    public GameObject Enemy;
    //public GameObject enemyPatyObj;
    public List<Vector3> basePosPaty1 = new List<Vector3>();
    public Quaternion q = new Quaternion();
    public bool flg = false;


	// Use this for initialization
	void Start () {
        //enemyPatyObj = gameObject.transform.Find("EnemyPaty1").gameObject;

        //if(enemyCreateStage == null)
        //{
        //    enemyCreateStage = GameObject.Find("EnemyPaty2");
        //}
        q = Quaternion.identity;
        //座標を配列へ入力
        basePosPaty1.Add(new Vector3(0.0f, 0.5f, this.gameObject.transform.position.z + 10.0f));
        basePosPaty1.Add(new Vector3(3.0f, 0.5f, this.gameObject.transform.position.z + 13.0f));
        basePosPaty1.Add(new Vector3(-3.0f, 0.5f, this.gameObject.transform.position.z + 13.0f));
        basePosPaty1.Add(new Vector3(6.0f, 0.5f, this.gameObject.transform.position.z + 16.0f));
        basePosPaty1.Add(new Vector3(-6.0f, 0.5f, this.gameObject.transform.position.z + 16.0f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit(Collider col)
    {
        //一回しか通らないようにフラグをチェック
        flg = true;
        Debug.Log("衝突判定成功");
        if (flg && col.gameObject.tag == "Player")
        {
            flg = false;        //入ったからフラグをオフ

            //オブジェクト生成ループ
            for (int i = 0; i < 5; i++)
            {
                Instantiate(Enemy, basePosPaty1[i], q);
                if (i >= 4)
                {
                    //判定用オブジェクトデストロイ
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
