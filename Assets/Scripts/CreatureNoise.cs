using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreatureNoise : MonoBehaviour
{
    [SerializeField]
    GameObject pressE;
    [SerializeField]
    Text text;

    bool triggerActive = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            text.text = (" : Pet");
            pressE.SetActive(true);
            triggerActive = true;
        }
    }

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggerActive == true)
        {
            //pressE.SetActive(false);
            gameObject.GetComponent<AudioSource>().Play();
        }
	}

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            pressE.SetActive(false);
            triggerActive = false;
        }
    }
}
