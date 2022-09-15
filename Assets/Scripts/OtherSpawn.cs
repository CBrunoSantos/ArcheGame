using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherSpawn : MonoBehaviour
{
    public float spawnRate;
    public GameObject enemy;
    private float nextSpawn = 0f;
    public float teste;

    void Update()
    {
        if(Time.time > nextSpawn){
            float testeT = Random.Range(-teste, teste);
            Debug.Log(testeT);
            nextSpawn = Time.time + spawnRate;
            Instantiate(enemy, transform.position*testeT, enemy.transform.rotation);
        }
    }
}
