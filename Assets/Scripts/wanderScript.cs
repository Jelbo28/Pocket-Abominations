using UnityEngine;
using System.Collections;

public class wanderScript : MonoBehaviour {

	[SerializeField]
	float Speed = 10f;
	[SerializeField]
	float Range = 10f;

	Vector3 waypoint;
	NavMeshAgent agent;


	void Awake()
	{
		agent = GetComponent<NavMeshAgent> ();
	}

	void Start()
	{
		Wander ();
	}

	void Update()
	{
		transform.position += transform.TransformDirection (Vector3.forward) * Speed * Time.deltaTime;
		if ((transform.position - waypoint).magnitude < 3) 
		{
			Wander ();
		}
	}

	void Wander()
	{
		waypoint = new Vector3 (Random.Range (transform.position.x - Range, transform.position.x + Range), 1, Random.Range (transform.position.z - Range, transform.position.z + Range));
		waypoint.y = 1;
		transform.LookAt (waypoint);
	}
}
