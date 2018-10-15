using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Experimental.UIElements;


public class DoTweenControl : MonoBehaviour {
    public Transform t; //インペクター上でセットされたオブジェクトのTransformを取得
    private Sequence mySequence;

	// Use this for initialization
	void Start () {
	    mySequence = DOTween.Sequence();
	    mySequence.Append(
	        t.DOMoveX(10.0f, 5.0f).SetEase(Ease.InQuad).OnComplete(()=>processCompleted())
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


    public void processCompleted() {
        mySequence.Restart();
        mySequence.Pause();
        t.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
