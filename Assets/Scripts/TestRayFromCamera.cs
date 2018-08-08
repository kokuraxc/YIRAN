using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRayFromCamera : MonoBehaviour {
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update () {
        Ray ray = cam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
    }
}
