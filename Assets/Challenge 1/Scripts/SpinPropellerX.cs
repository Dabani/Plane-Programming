using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Set and initialize the speed
    public float speed = 2000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the Propeller around the Z axis
        transform.Rotate(0,0, speed * Time.deltaTime, Space.Self);
    }
}
