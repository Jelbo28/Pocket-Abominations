using UnityEngine;
using System.Collections;

public class AbominationAI : MonoBehaviour
{
    bool gotRandom;
    float storeRandom;

    void Update()
    {
        Walk();
    }


    void Walk()
    {
        if (!gotRandom)
        {
            storeRandom = Random.Range(1, 6);
            gotRandom = true;
        }
    }
}
