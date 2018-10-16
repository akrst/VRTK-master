using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  VRTK;

public class ControllerEventTest : MonoBehaviour {
    
    private void OnEnable() {
        if (GetComponent<VRTK_ControllerEvents>() == null) {
            return;
        }
        GetComponent<VRTK_ControllerEvents>().TriggerPressed += TriggerPressedHandler;
    }

    private void OnDisable() {
        if (GetComponent<VRTK_ControllerEvents>() == null) {
            return;
        }
        GetComponent<VRTK_ControllerEvents>().TriggerPressed -= TriggerPressedHandler;
    }

    void TriggerPressedHandler(object sender, ControllerInteractionEventArgs e) {
        Debug.Log("call");
        GameObject[] targets = GameObject.FindGameObjectsWithTag("target");
        foreach (var target in targets) {
            if (target.transform.localScale.x > 0.05f) {
                Color color = new Color(Random.value, Random.value, Random.value);
                for (int i = 0; i < directions.Length; i++) {
                    var obj = Instantiate(target);
                    var cube = obj.transform;
                    cube.name = "Cube";
                    cube.localScale = 0.5f * target.transform.localScale;
                    cube.position = target.transform.TransformPoint(directions[i] / 4);
                    cube.GetComponent<Rigidbody>().AddForce(10.0f * Random.insideUnitSphere, ForceMode.VelocityChange);
                    cube.GetComponent<Renderer>().material.color = color;
                }
                Destroy(target);
            }
        }
    }

    private Vector3[] directions = {
        new Vector3(1, -1, 1),
        new Vector3(-1, -1, 1),
        new Vector3(-1, -1, -1),
        new Vector3(1, -1, -1),
        new Vector3(1, 1, 1),
        new Vector3(-1, 1, 1),
        new Vector3(-1, 1, -1),
        new Vector3(1, 1, -1),
    };
}
