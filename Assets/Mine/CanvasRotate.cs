using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasRotate : MonoBehaviour {
    private GameObject camera;
    
	// Use this for initialization
	void Start () {
		camera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
	    Vector3 p = camera.transform.position;
	    p.y = transform.position.y;
	    transform.LookAt(p);
	    
	    
	    /*
	    float speed = 0.1f;
	    // ターゲット方向のベクトルを取得
	    Vector3 relativePos = camera.transform.position - this.transform.position;
	    // 方向を、回転情報に変換
	    Quaternion rotation = Quaternion.LookRotation (relativePos);
	    // 現在の回転情報と、ターゲット方向の回転情報を補完する
	    transform.rotation  = Quaternion.Slerp (this.transform.rotation, rotation, speed);
	    */
	}
}
