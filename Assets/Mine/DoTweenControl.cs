using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Experimental.UIElements;


public class DoTweenControl : MonoBehaviour {
    public Transform t; //インペクター上でセットされたオブジェクトのTransformを取得
    public Vector3 startPosition;
    public float endPoint;
    public float speed;
    private Sequence mySequence;

	// Use this for initialization
	void Start () {
	    mySequence = DOTween.Sequence();
	    mySequence.Append(
	        // 基本の動きはここで設定
	        t.DOMoveX(endPoint, speed).SetEase(Ease.InQuad).OnComplete(()=>processCompleted())
	     );
	    mySequence.Pause();
	}

    public void Play() {
        mySequence.Play();
    }

    public void Pause() {
        mySequence.Pause();
    }

    public void Kill() {
        mySequence.Kill();
    }

    public void Restart() {
        mySequence.Restart();
    }

    // 動きが完了した際の動作を設定
    public void processCompleted() {
        mySequence.Restart();
        mySequence.Pause();
        t.transform.position = startPosition;
    }
}
