using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabsUp;
    public GameObject[] animalPrefabsRight;

    private float spawnRangeX = 15;
    private float maxSpawnRangeY = 15;
    private float minSpawnRangeY = 2;

    private float spawnPosZ = 20;
    private float spawnPosX = 22;

    private float startDelay = 2f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalUp", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalUp()
    {
        int animalIndex = Random.Range(0, animalPrefabsUp.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabsUp[animalIndex], spawnPos, animalPrefabsUp[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabsRight.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(minSpawnRangeY, maxSpawnRangeY));
        Instantiate(animalPrefabsRight[animalIndex], spawnPos, animalPrefabsRight[animalIndex].transform.rotation);
    }

}
