using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField]
	Animator anim;
    [SerializeField]
	GameObject pokeball;
    [SerializeField]
	float speed = 1f;
    [SerializeField]
    AudioSource[] sounds;
    public AudioSource goSound;
    public AudioSource playSound;


	public void Go()
	{  
		anim.SetBool("Rotate", false);
		anim.SetFloat ("RotateSpeed", 2.5f);
	}

    public void Play()
    {
        Debug.Log("Play");
        SceneManager.LoadScene("Introduction");
        //Application.LoadLevel("Introduction");
    }

	public void Quit()
	{
        Debug.Log("Quit");
        Application.Quit ();
	}

	public void Credits()
	{
        Debug.Log("Credits");
        SceneManager.LoadScene("Credits");
        //Application.LoadLevel ("Credits");
    }
}
