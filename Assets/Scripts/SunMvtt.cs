using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMvtt : MonoBehaviour
{
    
    public float DayLength;
    float _rotationSpeed;
    
   

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 v = new Vector3(1, 0, 0);
        transform.position = v;
        */
        _rotationSpeed = Time.deltaTime / DayLength;
    _rotationSpeed = Time.deltaTime / DayLength;
    transform.Rotate(0, _rotationSpeed, 0);
    }
}
