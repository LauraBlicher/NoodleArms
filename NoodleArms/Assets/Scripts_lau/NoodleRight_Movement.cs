using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoodleRight_Movement : MonoBehaviour {

    public float speed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position -= new Vector3( 0.0f, speed * Time.deltaTime, 0.0f);
    }

}
