using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float speedMove;

    void Update()
    {
        transform.Translate(Vector3.forward * speedMove * Time.deltaTime);
    }
}
