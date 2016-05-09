using UnityEngine;
using System.Collections;

public class WalkAround : MonoBehaviour {

	[SerializeField]
	Transform target;

	[SerializeField]
	int moveSpeed;

	int targetNumber;

	[SerializeField]
	int rotationSpeed;

	private Transform myTransform;
	private Transform stopDistance;

	void Awake()
	{
		myTransform = transform;
	}

	void Start()
	{
		GameObject go = GameObject.FindGameObjectWithTag ("WayPoint");
		target = go.transform;
	}

	void Update()
	{
		Debug.DrawLine (target.position, myTransform.position, Color.green);

		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Waypoint") 
		{
			gameObject.tag
		}
	}
}
