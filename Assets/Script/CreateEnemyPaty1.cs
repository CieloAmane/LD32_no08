using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyPaty1 : MonoBehaviour {

    public GameObject Enemy;
    public GameObject EnemyPaty1;
    public List<Vector3> basePosPaty1 = new List<Vector3>();
    public Quaternion q = new Quaternion();
    public bool flg = false;


	// Use this for initialization
	void Start () {
        q = Quaternion.identity;
        basePosPaty1.Add(new Vector3(0.0f, 0.5f, 30.0f));
        basePosPaty1.Add(new Vector3(3.0f, 0.5f, 33.0f));
        basePosPaty1.Add(new Vector3(-3.0f, 0.5f, 33.0f));
        basePosPaty1.Add(new Vector3(6.0f, 0.5f, 36.0f));
        basePosPaty1.Add(new Vector3(-6.0f, 0.5f, 36.0f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        Destroy(EnemyPaty1);
        flg = true;
        Debug.Log("衝突判定成功");
        if (flg)
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(Enemy, basePosPaty1[i], q);
                if (i >= 4)
                    flg = false;
            }
        }
    }
}
