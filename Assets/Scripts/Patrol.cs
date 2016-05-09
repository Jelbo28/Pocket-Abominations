using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour 
{

	[SerializeField]
	Transform[] waypoint;

	[SerializeField]
	float patrolSpeed = 10f;

	[SerializeField]
	bool loop = true;

	[SerializeField]
	float damping = 6f;

	float currentTime;

	Quaternion rotation;

	float pauseDuration = 0f;

	int currentWaypoint = 0;
	CharacterController abomination;

	void Start()
	{
		abomination = gameObject.GetComponent<CharacterController> ();
	}

	void Update()
	{
		if (currentWaypoint < waypoint.Length) 
		{
			PatrolAround ();
		}
		else
		{
			if (loop) 
			{
				currentWaypoint = 0;
			}	
		}
	}

	void PatrolAround()
	{
		Vector3 target = waypoint [currentWaypoint].position;
		target.y = transform.position.y;
		Vector3 moveDirection = target - transform.position;

		if (moveDirection.magnitude < 0.5f) 
		{
			if (currentTime == 0) 
			{
				currentTime = Time.time;
			}
			if ((Time.time - currentTime) >= pauseDuration) {
				currentWaypoint++;
				currentTime = 0;
			} 
			else
			{
				rotation = Quaternion.LookRotation (target - transform.position);
				transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
				abomination.Move (moveDirection.normalized * patrolSpeed * Time.deltaTime);
			}
		}
	}
}
