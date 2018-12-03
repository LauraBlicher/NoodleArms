using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour {
	[SerializeField] private float moveSpeed;
	[SerializeField] private GameObject pointA;
	[SerializeField] private GameObject pointB;
	[SerializeField] private bool reverseMove = false;
	[SerializeField] private Transform objectToUse;
	[SerializeField] private bool moveThisObject = false;
	private float startTime;
	private float journeyLength;
	private float distCovered;
	private float fracJourney;

	private bool move;
	public float delay = 3f;
	public float speed = 1f;

	void Start()
	{
		StartCoroutine (Delay ());
		startTime = Time.time;
		if (moveThisObject)
		{
			objectToUse = transform;
		}
		journeyLength = Vector3.Distance(pointA.transform.position, pointB.transform.position);
	}
	void Update()
	{
//		distCovered = (Time.time - startTime) * moveSpeed;
//		fracJourney = distCovered / journeyLength;
//		if (reverseMove)
//		{
//			objectToUse.position = Vector3.Lerp(pointB.transform.position, pointA.transform.position, fracJourney);
//		}
//		else
//		{
//			objectToUse.position = Vector3.Lerp(pointA.transform.position, pointB.transform.position, fracJourney);
//		}
//		if ((Vector3.Distance(objectToUse.position, pointB.transform.position) == 0.0f || Vector3.Distance(objectToUse.position, pointA.transform.position) == 0.0f)) //Checks if the object has travelled to one of the points
//		{
//			if (reverseMove)
//			{
//				reverseMove = false;
//			}
//			else
//			{
//				reverseMove = true;
//			}
//			startTime = Time.time;
//		}

		if (move) {
			transform.localPosition = new Vector3 (0f, Mathf.Lerp (transform.localPosition.y, transform.localPosition.y - speed * Time.deltaTime, speed * Time.deltaTime));
		}
	}

	IEnumerator Delay()
	{
		move = true;
		yield return new WaitForSeconds (delay);
		move = false;
	}
}