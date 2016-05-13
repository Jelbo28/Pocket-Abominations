using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorInteract : MonoBehaviour
{
    [SerializeField]
    GameObject pressE;
    [SerializeField]
    Text text;
    [SerializeField]
    string scene;

    bool triggerActive = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            text.text = (" : Open");
            pressE.SetActive(true);
            triggerActive = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggerActive == true)
        {
            pressE.SetActive(false);
            gameObject.GetComponent<AudioSource>().Play();
            StartCoroutine(LoadLevel(scene, 1));
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            pressE.SetActive(false);
        }
    }

    IEnumerator LoadLevel(string _name, float _delay)
    {
        yield return new WaitForSeconds(_delay);
        SceneManager.LoadScene(_name);
    }
}

