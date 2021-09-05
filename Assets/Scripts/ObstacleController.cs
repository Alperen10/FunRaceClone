using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float rotateSpeed;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(0,rotateSpeed,0);
    }
}
