using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        // hace que la camara persiga al jugador
        transform.position = player.transform.position + offset;
    }
}
