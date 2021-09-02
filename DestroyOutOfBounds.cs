using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public GameObject gameObjectt;
    float topBounds = 30.0f;
    float loverBound = -10;
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObjectt);
        }
        else if(transform.position.z > -10)
        {
            Destroy(gameObject);
        }
    }
}
