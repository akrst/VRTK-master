using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  VRTK;

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

        if (canvas.activeSelf == false) {
            canvas.SetActive(true);
        }
        else {
            canvas.SetActive(false);
        }
    }

}
