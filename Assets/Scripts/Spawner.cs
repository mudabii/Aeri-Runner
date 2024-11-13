using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacle;
    public float spawnDelay = 3.0f;
    private float time = 0f;
    public Transform spawn;




    void Update()
    {
        time += Time.deltaTime;
        if (time >= spawnDelay)
        {
            SpawnObstaculo();
            time = 0f;
        }
    }
    void SpawnObstaculo()
    {
        int Rand = Random.Range(0, obstacle.Length);
        Instantiate(obstacle[Rand], spawn.position, spawn.rotation);
    }
}