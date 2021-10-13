using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterMvt : MonoBehaviour
{
   public Transform target; //the object to rotate around
    public int speed; //the speed of rotation
    public float DayLengthJ;
    float _rotationSpeedJ;
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {

            target = this.gameObject.transform;
            Debug.Log("Rotate Around target not specified. Defaulting to Parent gameObject");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
        _rotationSpeedJ = Time.deltaTime / DayLengthJ;
    transform.Rotate(0, _rotationSpeedJ, 0);
    }
}
