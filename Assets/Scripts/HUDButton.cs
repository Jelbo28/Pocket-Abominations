using UnityEngine;
using System.Collections;

public class HUDButton : MonoBehaviour
{
    [SerializeField]
    GameObject stats;
    [SerializeField]
    GameObject back;
    [SerializeField]
    GameObject forward;
    [SerializeField]
    GameObject story;

    public void OnClickForward()
    {
        stats.SetActive(false);
        story.SetActive(true);
        back.SetActive(true);
        forward.SetActive(false);
    }

    public void OnClickBack()
    {
        stats.SetActive(true);
        story.SetActive(false);
        back.SetActive(false);
        forward.SetActive(true);
    }

    public void PlaySound()
    {
        gameObject.GetComponent<AudioSource>().Play(0);
    }
}
