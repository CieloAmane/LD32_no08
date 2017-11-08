using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMove : MonoBehaviour {

    public float bulletSpeed= 15.0f;
    public int destroyTime = 5;
    public int cnt = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        BulletMove();
        DestroyBullet();
	}

    void BulletMove()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }

    void DestroyBullet()
    {
        if (destroyTime * 60 <= cnt)
        {
            Debug.Log("shotオブジェクト破壊");
            Destroy(this.gameObject);
        }
        cnt++;
        //Debug.Log("ShotCnt:" + cnt);
    }
}
