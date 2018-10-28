using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    #region Variables
    public GameObject enemyToSpwn;

    public bool canSpawn = true;
    public float enemySpawnTime = 0.5f;
    public float maxY = 8.0f;
    public float startingX = 25.0f;

    float randomY = 0.0f;

    #endregion
    private void Start()
    {
        StartCoroutine(SpawnEnemyTimer());
    }


    IEnumerator SpawnEnemyTimer()
    {
        while(canSpawn == true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(enemySpawnTime);
        }
    }

    void SpawnEnemy()
    {
        randomY = Random.Range(-maxY, maxY);

        Instantiate(enemyToSpwn, new Vector3(startingX, randomY, 0), Quaternion.identity);
    }

}// main class
