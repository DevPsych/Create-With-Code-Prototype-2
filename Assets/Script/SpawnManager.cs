using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX =  20.0f;
    private float spawnRangeZ = 15.0f;
    private float spawnPosX = 25.0f;
    private float spawnPosZ = 15.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomTopAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomLeftAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomRightAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomTopAnimal()
    {
        //Choose random animal from animalPrefabs index
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //Intantiate the spawnPos of animals, randomly within the X axis, no y axis, and at a determined z axis
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomLeftAnimal()
    {
        //Choose random animal from animalPrefabs index
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //Intantiate the spawnPos of animals, randomly within the X axis, no y axis, and at a determined z axis
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(0, spawnRangeZ));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.right));
    }

    void SpawnRandomRightAnimal()
    {
        //Choose random animal from animalPrefabs index
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //Intantiate the spawnPos of animals, randomly within the X axis, no y axis, and at a determined z axis
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(0, spawnRangeZ));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.left));
    }
}
