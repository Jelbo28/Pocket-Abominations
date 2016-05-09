using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WalkAround : MonoBehaviour {

	[SerializeField]
	Transform target;

	[SerializeField]
	int moveSpeed = 1;

	int targetNumber;

	[SerializeField]
	int rotationSpeed = 1;

	private Transform myTransform;
	private Transform stopDistance;

	public List <Vector3> wayPoints;

	Vector3 nextWayPoint;

	void Awake()
	{
		myTransform = transform;
	}

	void Start()
	{
		GameObject go = GameObject.FindGameObjectWithTag ("WayPoint0");
		target = go.transform;
	}

	void Update()
	{
		Debug.DrawLine (target.position, myTransform.position, Color.green);

		myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (target.position - myTransform.position), rotationSpeed * Time.deltaTime);

		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

		//move to the nextwaypoint;
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "WayPoint0") 
		{
			//nextWayPoint = wayPoints[1];

			StartCoroutine (WaitToWalk (0));

		}
		if(collider.gameObject.tag == "WayPoint1")
		{
			//nextWayPoint = wayPoints [2];
			//StartCoroutine (WaitToWalk ());
			StartCoroutine (WaitToWalk (1));
		}
		if(collider.gameObject.tag == "WayPoint2")
		{
			//nextWayPoint = wayPoints [3];
			StartCoroutine (WaitToWalk (2));
			//target.position = wayPoints [3];
		}
		if(collider.gameObject.tag == "WayPoint3")
		{
			//nextWayPoint = wayPoints [4];
			StartCoroutine (WaitToWalk (3));
			//target.position = wayPoints [4];
		}
		if(collider.gameObject.tag == "WayPoint4")
		{
			//nextWayPoint = wayPoints [5];
			StartCoroutine (WaitToWalk (4));
			//target.position = wayPoints [5];
		}
		if(collider.gameObject.tag == "WayPoint5")
		{
			//nextWayPoint = wayPoints [6];
			StartCoroutine (WaitToWalk (5));
			//target.position = wayPoints [6];
		}
		if(collider.gameObject.tag == "WayPoint6")
		{
			//nextWayPoint = wayPoints [7];
			StartCoroutine (WaitToWalk (6));
			//target.position = wayPoints [7];
		}
		if(collider.gameObject.tag == "WayPoint7")
		{
			//nextWayPoint = wayPoints [8];
			StartCoroutine (WaitToWalk (7));
			//target.position = wayPoints [8];
		}
		if(collider.gameObject.tag == "WayPoint8")
		{
			//nextWayPoint = wayPoints [9];
			StartCoroutine (WaitToWalk (8));
			//target.position = wayPoints [9];
		}
		if(collider.gameObject.tag == "WayPoint9")
		{
			//nextWayPoint = wayPoints [10];
			StartCoroutine (WaitToWalk (9));
			//target.position = wayPoints [10];
		}
		if(collider.gameObject.tag == "WayPoint10")
		{
			//nextWayPoint = wayPoints [11];
			StartCoroutine (WaitToWalk (10));
			//target.position = wayPoints [11];
		}
		if (collider.gameObject.tag == "WayPoint11") 
		{
			//nextWayPoint = wayPoints[0]
			StartCoroutine (WaitToWalk (-1));
			//target.position = wayPoints [0];
		}





	}

	IEnumerator WaitToWalk(int previousway)
	{
		yield return new WaitForSeconds (1);
		target.position = wayPoints [previousway + 1];
	}
}
