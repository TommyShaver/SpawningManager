using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // call how big the arry is in unity since its public.
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    public float spawnDelay = 2;
    public float spawnInterval = 3f;
    private float sideSpawnMinZ = 1;
    private float sideSpawnMaxZ = 10;
    private float sideSpawnX = 20;
   
    // Start is called before the first frame update
    private void Start()
    {
        //Calling this function at the start will keep spawning. it has to be in the start or it will spawn every frame.
        InvokeRepeating("SpawnRandoAnimal", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnRightAnimal", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnLeftAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //This the function to spawn random things. It has an index array of opstion to spawn and also a  random range to spawn it.
    void SpawnRandoAnimal()
    {
        //How to spawn differnt elements from an array using random value.
        int animalIndex = Random.Range(0, animalPrefabs.Length);






        //How to get prefabs to spawn different location on the map. these numbers where called from varibles in the beginning of the class.
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);







        //how to spawn differnt things from an anrry index manager. Using a Vector3 call where they spawn and call the roation from the prefeab.
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    //Get this to spawn on the side of the map
    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));

    }
    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
    
    
}
