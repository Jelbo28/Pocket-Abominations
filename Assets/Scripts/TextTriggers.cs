using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextTriggers : MonoBehaviour
{
	[SerializeField]
	GameObject hello;
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			hello.SetActive(true);
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
