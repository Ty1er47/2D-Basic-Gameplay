using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject [] enemyPreFabs;

    public float spawnXRange = 8;
    public float spawnYRange = 10;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            SpawnRandomEnemy();
        }

    }
    void SpawnRandomEnemy()
    {
        int index = Random.Range(0, enemyPreFabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnXRange,spawnXRange),spawnYRange,0);
            Instantiate(enemyPreFabs[index], spawnPos,enemyPreFabs[index].transform.rotation);
    }
}
