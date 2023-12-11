using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombie;
    
    public int maxZombie;

    public float zombieCount;

    public float spawnDelay;

    public List<GameObject> spawnerList;

    private void Update()
    {
        zombieCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (zombieCount < maxZombie)
        {
            Spawn();
            
            Invoke(nameof(Spawn), spawnDelay);
        }
    }

    private void Spawn()
    {
        GameObject choseSpawner = spawnerList[Random.Range(0, spawnerList.Count)];
        Instantiate(zombie, choseSpawner.transform.position, choseSpawner.transform.rotation);
    }
}
