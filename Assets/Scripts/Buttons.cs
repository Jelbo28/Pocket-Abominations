using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
	public Animator anim;
	public GameObject pokeball;
	public float speed = 1f;

	public void Play()
	{
		//Application.LoadLevel ("Introduction");

		anim.SetBool("Rotate", false);
		anim.SetFloat ("RotateSpeed", 2.5f);

	}

	public void Quit()
	{
		Application.Quit ();
	}

	public void Credits()
	{
		//Application.LoadLevel ("Credits");
	}
}
