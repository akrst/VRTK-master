using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using DG.Tweening;

public class ButtonOneEvent: MonoBehaviour {
  
    private void OnEnable() {
        if (GetComponent<VRTK_ControllerEvents>() == null) {
            return;
        }
        GetComponent<VRTK_ControllerEvents>().ButtonOnePressed += ButtonOnePressedHandler;
    }

    private void OnDisable() {
        if (GetComponent<VRTK_ControllerEvents>() == null) {
            return;
        }
        GetComponent<VRTK_ControllerEvents>().ButtonOnePressed -= ButtonOnePressedHandler;
    }

    void ButtonOnePressedHandler(object sender, ControllerInteractionEventArgs e) {
        GameObject parent = GameObject.Find("CanvasManager");
        GameObject canvas = parent.transform.Find("Canvas").gameObject;
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        Vector3 t = camera.transform.position;
        t += new Vector3(0.0f, 1.0f, 2.0f);

        if (canvas.activeSelf == false) {
            canvas.SetActive(true);
            RectTransform RT = canvas.GetComponent<RectTransform>();
            RT.transform.position = t;
            RT.localScale = new Vector3(0.0005f, 0.0005f, 0.0005f);
            RT.DOScale(new Vector3(0.002f, 0.002f, 0.002f), 0.5f).SetEase(Ease.InQuad);
        }
        else {
            canvas.SetActive(false);
        }
    }

}
