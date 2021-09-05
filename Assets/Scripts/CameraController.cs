using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject MaleFree1;
    Vector3 distance;
    void Start()
    {
        distance = transform.position - MaleFree1.transform.position;
    }


    void Update()
    {
        if (gameManager.isActive)
        {
            transform.position = MaleFree1.transform.position + distance;
        }

       
    }
}
