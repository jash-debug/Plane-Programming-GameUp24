using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate propeller along z axis
        float rotationSpeed = 1000f; // Adjust this value to change the speed
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime, Space.World);

    }
}
