using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    private float speedMove = 9.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * speedMove * Time.deltaTime);
    }

    // Detectar collision a zonas de collision para destruir el gameobjet
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("collisionZone"))
        {
            Destroy(gameObject);
        }
    }
}
