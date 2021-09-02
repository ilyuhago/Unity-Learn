using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   // public GameObject Player;
    float speedPlayer = 10f;
    public GameObject prefab;
    float horizontal;
    float vertical;

    public float xRange1;
    public float xRange2;

    public float zRange1;
    public float zRange2;

    void Update()
    {
   

            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            transform.Translate(Vector3.right * Time.deltaTime * horizontal * speedPlayer);
            transform.Translate(Vector3.forward * Time.deltaTime * vertical * speedPlayer);

        if(transform.position.x > xRange1 || transform.position.x < xRange2)
        {
            transform.position = new Vector3(0f,0f,0f);
        }
       
        if (transform.position.z > zRange1 || transform.position.z < zRange2)
        {
            transform.position = new Vector3(0f, 0f, 0f);
            Debug.Log("вы вышли за пределы, через 3 сек вы будуете возвращены");
           
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, prefab.transform.rotation);
        }
    }
}
