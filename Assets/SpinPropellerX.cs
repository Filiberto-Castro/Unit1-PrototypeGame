using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private Vector3 rotateChange = new Vector3(0, 0, 5.0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move the propeller of plane
        transform.Rotate(rotateChange);
    }
}
