using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotManager : MonoBehaviour {

    public float recast = 4.0f;
    private float recastTime = 0;
    private float recastCnt = 0;
    public bool recastFlg = false;

    public float bulletSpeed = 10.0f;
    public int bulletPattern = 1;

    public GameObject buleet;
    public GameObject shotMuzzel;
    private Vector3 bulletPosition;
    private Quaternion q = new Quaternion(0,0,0,0);

    public Transform shotTarget;

    private static int cnt = 0;
    private static int firingCnt = 0;

	// Use this for initialization
	void Start () {
        recastTime = 1 / recast;    //リキャストタイム計算
	}
	
	// Update is called once per frame
	void Update () {
            if(recastFlg)
            {
               Debug.Log("弾の作成");
                BulletCreate(bulletPattern);
            } else {
                RecastManager();
            }
            //Debug.Log("cnt / " + cnt);
            cnt++;
		}

    void BulletCreate(int pattern)
    {
        //Debug.Log("弾作るぜぇ");
        switch(pattern)
        {
            case 0: //弾の種類　［ - ］
                Debug.Log("発射：Pattern 0");
                Instantiate(buleet, shotMuzzel.transform.position, q);
                recastFlg = false;
                break;

            case 1: // 弾の種類　［ = = = ］
                Debug.Log("発射：Pattern 1");
                if(firingCnt < 3)
                {
                    if (cnt % 20 == 0)
                    {
                        bulletPosition = shotMuzzel.transform.position + new Vector3(-0.5f, 0.0f, 0.0f);
                        Instantiate(buleet, bulletPosition, q);

                        bulletPosition = shotMuzzel.transform.position + new Vector3(0.5f, 0.0f, 0.0f);
                        Instantiate(buleet, bulletPosition, q);
                        firingCnt++;
                    }
                } else {
                    firingCnt = 0;
                    cnt = 0;
                    recastFlg = false;
                }
                break;
        }
    }




    void RecastManager()
    {
        if (cnt >= 60)
        {
            if (recastCnt >= 1)
            {
                Debug.Log("リキャスト完了");
                recastCnt = 0;
                recastFlg =  true;
            }
            //Debug.Log(recastCnt);
            //Debug.Log(recastTime);
            
            recastCnt += recastTime;
            cnt = 0;
        }
        //Debug.Log("CNT : " + cnt);
    }
}
