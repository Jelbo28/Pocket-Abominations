using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	public void Play()
	{
		Application.LoadLevel ("Introduction");
	}

	public void Quit()
	{
		Application.Quit ();
	}

	public void Credits()
	{
		Application.LoadLevel ("Credits");
	}
}
