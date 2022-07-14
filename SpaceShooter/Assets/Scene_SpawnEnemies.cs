using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_SpawnEnemies : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float shootDelay = 0.5f;
    [SerializeField] Transform[] spawnPoints;


    void Start()
    {
        StartCoroutine(Co_spawnEnemies());
    }

    IEnumerator Co_spawnEnemies()
    {
        SpawnInPoints();

        yield return new WaitForSeconds(shootDelay);

        StartCoroutine(Co_spawnEnemies());
    }

    void SpawnInPoints()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            SpawnEnemy(spawnPoints[i]);
        }

    }

    void SpawnEnemy(Transform Point)
    {
        Instantiate(enemyPrefab, Point.position, Point.rotation);
    }
}
