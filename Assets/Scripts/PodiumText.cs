using UnityEngine;
using System.Collections;

public class PodiumText : MonoBehaviour 
{
	[SerializeField]
	GameObject hello;
	[SerializeField] 
	GameObject Next;

	bool triggerActive = false;
	
	void OnTriggerEnter(Collider other)
	{
		hello.SetActive(true);
		triggerActive = true;
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.E) && triggerActive == true)
		{
			hello.SetActive (false);
			Next.SetActive (true);
		}
	}
	
	void OnTriggerExit (Collider other)
	{
		if(other.tag == "Player")
		{
			hello.SetActive(false);
			Next.SetActive (false);
		}
	}
}
