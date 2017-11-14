using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;//Convertを使う場合は忘れずに書く

public class DistanceDisplay : MonoBehaviour {
    public Text distanceText;
    public GameObject playerObj;
    public int distanceM = 5000;
    public string distanceStr = "";

    // Use this for initialization
	void Start () {
        playerObj = GameObject.Find("Player");
        distanceText.text = distanceM + "m";
	}
	
	// Update is called once per frame
	void Update () {
        distanceStr = Convert.ToString(distanceM - (int)playerObj.transform.position.z);

        distanceText.text = distanceStr + "m";

        if(distanceM - (int)playerObj.transform.position.z <= 0)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
	}
}
