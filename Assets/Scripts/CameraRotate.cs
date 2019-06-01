using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

    public Camera cam;
    public float RoateRate = 10f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cam.transform.Rotate(Vector3.up, RoateRate * Time.deltaTime);
    }
}
