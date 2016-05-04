using UnityEngine;
using System.Collections;

public class AbominationAI : MonoBehaviour
{
    [SerializeField]
    float speed = 10f;

    Vector3 wayPoint;

    bool wait;

    float timeRandom = 0f;

    void Start()
    {
        wait = false;
        Wander();
    }

    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime;
        if((transform.position - wayPoint).magnitude < 3)
        {
            //StartCoroutine(Wait());
            Wander();
        }
    }

    void Wander()
    {
        if(wait == false)
        {
            timeRandom = Random.Range(1f, 6f);
            wayPoint = Random.insideUnitSphere * 47;
            wayPoint.y = 1;
            transform.LookAt(wayPoint);
            Debug.Log(wayPoint + " and " + (transform.position - wayPoint).magnitude);
        }
        wait = true;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(timeRandom);
        wait = false;
        Debug.Log("Wait " + timeRandom);
    }
}
