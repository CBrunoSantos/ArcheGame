using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    // private float spawnRate;
    private float nextSpawn = 0;
    // public GameObject enemy;
    // public float spawnRate;
    // private float nextSpawn = 0f;
    void Update(){
        // if(Time.time > nextSpawn){
        //     nextSpawn = Time.time + spawnRate;
        //     Instantiate(enemy, transform.position *10f, enemy.transform.rotation);
        // }
        if(Time.time > nextSpawn){
            float teste= Random.Range(0, 2f);
            nextSpawn = Time.time + teste;
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
    }
}
