using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAndroidOrientation : MonoBehaviour {
    Vector3 initAttitude;
    Vector3 curAttitude;

    // Use this for initialization
    void Start () {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
            initAttitude = Input.gyro.attitude.eulerAngles;
        }
	}
	
	// Update is called once per frame
	void Update () {
        curAttitude = Input.gyro.attitude.eulerAngles;
        float xdiff = curAttitude.x - initAttitude.x; // -5, 5
        float ydiff = curAttitude.y - initAttitude.y; // -1, 1
        xdiff = Mathf.Clamp(xdiff, -30, 30) / 6;
        ydiff = Mathf.Clamp(ydiff, -10, 10) / 10;

        transform.position = new Vector3(xdiff, ydiff, transform.position.z);
    }

    private void OnGUI()
    {
        if(GUI.Button(new Rect(50, 50, 100, 40), "Reset"))
        {
            initAttitude = Input.gyro.attitude.eulerAngles;
        }
        GUI.Label(new Rect(50, 100, 200, 40), curAttitude.ToString());
    }
}
