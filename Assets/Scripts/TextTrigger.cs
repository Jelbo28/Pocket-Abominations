using UnityEngine;
using System.Collections;

public class TextTrigger : MonoBehaviour 
{
	[SerializeField]
	GameObject hello;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			hello.SetActive(true);
			//gameObject.GetComponent<MeshRenderer>().enabled = true;
		}  
	}

	void OnTriggerExit (Collider other)
	{
		if(other.tag == "Player")
		{
			hello.SetActive(false);
			Debug.Log ("Poof");
		}
	}
}
