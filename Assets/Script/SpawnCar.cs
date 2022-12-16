using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    // lista para las posiciones de spawn
    public List<Transform> spawnPoint = new List<Transform>();
    // Array de gameobject para los vehiculos
    public GameObject[] car;
    
    public float spawnTime;
    public float maxTime;
    public float minTime;
    public float randomTime;

    public bool canSpawn;
    public bool firtsSpawnCar;

    private void Start() {
        canSpawn = true;
        firtsSpawnCar = true;
    }

    void Update()
    {
        spawnTime += Time.deltaTime;

        //Generando vehiculos
        if(canSpawn)
        {
            randomTime = Random.Range(minTime, maxTime);
            canSpawn = false;
            if(firtsSpawnCar)
            {
                randomTime = 0;
                firtsSpawnCar = false;
            }
        } else if(spawnTime >= randomTime)
        {
            // Generar vehiculo de manera aleatoria y en posision aleatoria
            GameObject newCar = Instantiate(car[Random.Range(0, car.Length)], spawnPoint[Random.Range(0, spawnPoint.Count)].transform.position, transform.rotation);
            spawnTime = 0;
            canSpawn = true;
        }
    }
}
