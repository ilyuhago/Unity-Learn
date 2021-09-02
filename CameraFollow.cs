using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject CAam;
    Vector3 posCam = new Vector3(0.64f, 25f, 0.26f);

    void Update()
    {
        transform.position = CAam.transform.position + posCam;   
    }
}
