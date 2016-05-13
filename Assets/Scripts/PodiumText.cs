using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PodiumText : MonoBehaviour 
{
	[SerializeField]
	GameObject pressE;
    [SerializeField]
    Text text;
	[SerializeField] 
	GameObject Next;

	bool triggerActive = false;
	
	void OnTriggerEnter(Collider other)
	{
        text.text = (" : Read");
		pressE.SetActive(true);
		triggerActive = true;
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.E) && triggerActive == true)
		{
            pressE.SetActive (false);
			Next.SetActive (true);
		}
	}
	
	void OnTriggerExit (Collider other)
	{
		if(other.tag == "Player")
		{
            pressE.SetActive(false);
			Next.SetActive (false);
		}
	}
}
