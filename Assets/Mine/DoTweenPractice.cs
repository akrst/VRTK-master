using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenPractice : MonoBehaviour {
    [SerializeField] GameObject obj;

	// Use this for initialization
	void Start () {
	    TDOMove();

	}
	
	// Update is called once per frame
	void Update () {
	}

    void TDOMove() {
        Transform transform = obj.transform;
        transform.DOMove(Vector3.one, 1.0f).SetEase(Ease.InOutCirc).SetRelative();
    }

    void TDOScale() {
        Transform transform = obj.transform;
        transform.DOScale(Vector3.zero, 10.0f);
    }
}
