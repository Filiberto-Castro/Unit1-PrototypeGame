using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(15, 2, 0.0f);

    void Update()
    {
        // Hace que la camara sigua al avion
        transform.position = plane.transform.position + offset;
    }
}
