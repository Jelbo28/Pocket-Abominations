using UnityEngine;
using System.Collections;

public class AbominationAI : MonoBehaviour
{
    [SerializeField]
    float speed = 10f;

    Vector3 wayPoint;

    float timeRandom = 0f;

    void Start()
    {
        Wander();
    }

    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime;
        if((transform.position - wayPoint).magnitude < 3)
        {
            StartCoroutine(Wait());
            Wander();
        }
    }

    void Wander()
    {
        timeRandom = Random.Range(1f, 6f);
        wayPoint = Random.insideUnitSphere * 47;
        wayPoint.y = 1;
        transform.LookAt(wayPoint);
        Debug.Log(wayPoint + " and " + (transform.position - wayPoint).magnitude);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(timeRandom);
        Debug.Log("Wait " + timeRandom);
    }
}
