using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasRotate : MonoBehaviour {
    private GameObject camera;
    private GameObject canvasPoint;
    
	// Use this for initialization
	void Start () {
	    canvasPoint = GameObject.Find("CanvasPoint");
	    Debug.Log(canvasPoint);
		camera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
	    Vector3 canvasPointPosition = canvasPoint.transform.position;
	    // transform.position = canvasPointPosition;
	    transform.position = Vector3.Lerp(transform.position, canvasPointPosition, 6.0f *Time.deltaTime);
	    Vector3 p = camera.transform.position;
	    // p.y = transform.position.y;
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
