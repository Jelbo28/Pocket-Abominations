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

	public List <GameObject> GO_wayPoints;

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

		myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (target.position - myTransform.position), rotationSpeed * Time.deltaTime * 2);

		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

		//move to the nextwaypoint;
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "WayPoint0") 
		{
			StartCoroutine (WaitToWalk (0));
		}
		if(collider.gameObject.tag == "WayPoint1")
		{
			StartCoroutine (WaitToWalk (1));
		}
		if(collider.gameObject.tag == "WayPoint2")
		{
			StartCoroutine (WaitToWalk (2));
		}
		if(collider.gameObject.tag == "WayPoint3")
		{
			StartCoroutine (WaitToWalk (3));
		}
		if(collider.gameObject.tag == "WayPoint4")
		{
			StartCoroutine (WaitToWalk (4));
		}
		if(collider.gameObject.tag == "WayPoint5")
		{
			StartCoroutine (WaitToWalk (5));
		}
		if(collider.gameObject.tag == "WayPoint6")
		{
			StartCoroutine (WaitToWalk (6));
		}
		if(collider.gameObject.tag == "WayPoint7")
		{
			StartCoroutine (WaitToWalk (7));
		}
		if(collider.gameObject.tag == "WayPoint8")
		{
			StartCoroutine (WaitToWalk (8));
		}
		if(collider.gameObject.tag == "WayPoint9")
		{
			StartCoroutine (WaitToWalk (9));
		}
		if(collider.gameObject.tag == "WayPoint10")
		{
			StartCoroutine (WaitToWalk (10));
		}
		if (collider.gameObject.tag == "WayPoint11") 
		{
			StartCoroutine (WaitToWalk (11));
		}

	}

	IEnumerator WaitToWalk(int previousway)
	{
		yield return new WaitForSeconds (1);
		GO_wayPoints [previousway].SetActive (false);
		GO_wayPoints [(previousway + 1) % 12].SetActive (true);
		target.position = GO_wayPoints [(previousway + 1) % 12].transform.position;

	}
}
