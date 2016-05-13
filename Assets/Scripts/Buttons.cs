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
    AudioSource boop1;
    [SerializeField]
    AudioSource boop2;
    [SerializeField]
    AudioSource boop3;

    public void Go()
	{
        boop1.Play(0);
		anim.SetBool("Rotate", false);
		anim.SetFloat ("RotateSpeed", 2.5f);
	}

    public void Play()
    {
        Debug.Log("Play");
        StartCoroutine(LoadLevel("Introduction", 1f));
        //Application.LoadLevel("Introduction");
    }

    public void PlaySound()
    {
        boop1.Play(0);
    }

    public void QuitSound()
    {
        boop3.Play(0);
    }

    public void CreditsSound()
    {
        boop2.Play(0);
    }

    public void Quit()
	{
        Debug.Log("Quit");
        StartCoroutine(LoadLevel("Quit", 1f));
    }

    public void Credits()
	{
        Debug.Log("Credits");
        StartCoroutine(LoadLevel("Credits", 1f));
        //Application.LoadLevel ("Credits");
    }

    IEnumerator LoadLevel(string _name, float _delay)
    {
        yield return new WaitForSeconds(_delay);
        if (_name == "Quit")
        {
            Application.Quit();
        }
        SceneManager.LoadScene(_name);
    }
}
