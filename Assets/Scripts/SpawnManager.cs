using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //array de animales
    public int animalIndex; //Indice de animales
    
    private float spawnRangeX = 14f;
    private float spawnPosZ = 19f;

    private float startDelay = 1.5f;
    private float spawnInterval = 2f;
    private void Start()
    {//Llama periodicamente a un animal aleatorio
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 10), animalPrefabs[animalIndex].transform.rotation);
        }
    }*/
    private void SpawnRandomAnimal()//posicion aleatoria
        {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], position: RandomSpawnPos(), animalPrefabs[animalIndex].transform.rotation);
        }
    private Vector3 RandomSpawnPos()//Da vector aleatorio
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomX, 0, spawnPosZ);
    }
}
