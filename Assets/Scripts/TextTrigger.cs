using UnityEngine;
using System.Collections;

public class TextTrigger : MonoBehaviour 
{
	void OnStart()
	{
		gameObject.GetComponent<MeshRenderer>().enabled = false;
	}

	void OntriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			gameObject.GetComponent<MeshRenderer>().enabled = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		gameObject.GetComponent<MeshRenderer>().enabled = false;
	}
}
