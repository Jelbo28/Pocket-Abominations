using UnityEngine;
using System.Collections;

public class LerpRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("a"))
        {
            gameObject.GetComponent<Animator>().SetBool("Rotate", false);
            //gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, new Quaternion(0, 180, 0, 0), 0.2f);
        }
	
	}
}
