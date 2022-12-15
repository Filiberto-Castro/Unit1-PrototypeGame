using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // variables de la camara principal
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // variables para el cambio de camara
    private bool camaraActiva;
    public GameObject cameraFPS;

    void Start()
    {
        cameraFPS.SetActive(false);
        camaraActiva = true;
    }

    void LateUpdate()
    {
        // hace que la camara persiga al jugador
        transform.position = player.transform.position + offset;

        // cambiar a camara de primera persona
        if(Input.GetKeyDown(KeyCode.F) && camaraActiva)
        {
            cameraFPS.SetActive(true);
            camaraActiva = false;
        }else if(Input.GetKeyDown(KeyCode.F) && !camaraActiva) // cambiar a tercera persona
        {
            cameraFPS.SetActive(false);
            camaraActiva = true;
        }
    }
}
