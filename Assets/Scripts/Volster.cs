using UnityEngine;
using System.Collections;

public class Volster : MonoBehaviour 
{
	[SerializeField]
	GameObject Hello;
	bool triggerActive = false;

	void OnTriggerEnter(Collider other)
	{
		Hello.SetActive(true);
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.E) && triggerActive == true)
		{
			Hello.SetActive (false);
			//SceneManager.LoadScene("Volster");
			//Application.LoadLevel("Volster");
			Debug.Log ("Wut?");
		}
	}
}
