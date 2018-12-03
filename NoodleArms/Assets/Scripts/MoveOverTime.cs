using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOverTime : MonoBehaviour {

	public Transform target;
	public float speed;

	void update (){
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);
	}
}
