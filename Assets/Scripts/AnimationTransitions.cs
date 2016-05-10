
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnimationTransitions : MonoBehaviour
{
    [SerializeField]
    Animator exitAnimator;

    [SerializeField]
    Animator canvasAnimatior;

    [SerializeField]
    Animator cameraAnimator;

    [SerializeField]
    Animator fadeAnimator;

    [SerializeField]
    GameObject fade;

    public void Menu()
    {
        Debug.Log("Back to menu.");
        SceneManager.LoadScene("openingScene");
        // Use this to load whatever scene the title screen is on.
        //SceneManager.LoadScene(1);
    }

    public void ButtonGlow()
    {
        exitAnimator.SetBool("ButtonGlow", true);
    }

    public void BallOpen()
    {
        canvasAnimatior.SetBool("Zoom", true);
        cameraAnimator.SetBool("Camera", true);

    }

    public void Fade()
    {
        fade.SetActive(true);
        fadeAnimator.SetBool("Fade", true);
    }
}