using UnityEngine;
using System.Collections;

public class TextDissapear : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.gameObject.SetActive(false);
        }
	}
}
