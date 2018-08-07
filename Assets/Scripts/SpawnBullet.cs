using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour {
    public GameObject bulletPrefab;
    public Transform spawnTrans;
    Vector3 direction;

    bool dragging = false;
    float dragStartTime;
    Vector2 dragStartLoc;
    float dragEndTime;
    Vector2 dragEndLoc;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {


            

            
        }

        if (Input.GetMouseButtonDown(0))
        {
            dragStartTime = Time.time;
            dragStartLoc = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            dragEndTime = Time.time;
            dragEndLoc = Input.mousePosition;

            spawn();
        }
	}

    public float factor = 3;
    void spawn()
    {
        float time = dragEndTime - dragStartTime;
        Vector2 distance = dragEndLoc - dragStartLoc;
        Vector3 velocity = new Vector3(distance.x, distance.y, 1 / time * 100);
        velocity = velocity.normalized * factor;

        var bullet = Instantiate<GameObject>(bulletPrefab, spawnTrans);
        bullet.transform.parent = null;
        bullet.GetComponent<Rigidbody>().AddForce(velocity, ForceMode.VelocityChange);
    }
}
