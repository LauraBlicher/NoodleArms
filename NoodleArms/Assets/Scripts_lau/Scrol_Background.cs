using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrol_Background : MonoBehaviour {

    public float csrollSpeed = -0.5f;
    Vector2 startPos;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        float newPos = Mathf.Repeat(Time.time * csrollSpeed, 130);
        transform.position = startPos + Vector2.right * newPos;


	}
}
