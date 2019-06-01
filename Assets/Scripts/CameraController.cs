using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Camera cam;
    public float MoveRate = 1f;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            cam.transform.Translate(Vector3.left * MoveRate * Time.deltaTime, Space.World);
        }


        if (Input.GetKey(KeyCode.D))
        {
            cam.transform.Translate(Vector3.right * MoveRate * Time.deltaTime, Space.World);
        }


        if (Input.GetKey(KeyCode.W))
        {
            cam.transform.Translate(Vector3.forward * MoveRate * Time.deltaTime, Space.World);
        }


        if (Input.GetKey(KeyCode.S))
        {
            cam.transform.Translate(Vector3.back * MoveRate * Time.deltaTime, Space.World);
        }


        if (Input.GetKey(KeyCode.P))
        {
            cam.transform.Translate(Vector3.up * MoveRate * Time.deltaTime, Space.World);
        }


        if (Input.GetKey(KeyCode.L))
        {
            cam.transform.Translate(Vector3.down * MoveRate * Time.deltaTime, Space.World);
        }


    }
}
