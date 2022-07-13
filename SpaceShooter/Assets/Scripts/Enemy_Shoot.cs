using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shoot : MonoBehaviour
{
    [SerializeField] Rigidbody2D bulletPrefab;
    [SerializeField] float bulletSpeed = 5f;
    [SerializeField] float shootDelay = 0.5f;
    [SerializeField] Transform[] spawnPoints;


    void Start()
    {
        StartCoroutine(Co_spawnBullets());
    }

    IEnumerator Co_spawnBullets()
    {
        SpawnInPoints();

        yield return new WaitForSeconds(shootDelay);

        StartCoroutine(Co_spawnBullets());
    }

    void SpawnInPoints()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            InstantiateBullets(spawnPoints[i]);
        }

    }

    void InstantiateBullets(Transform Point)
    {
        Rigidbody2D bulletInstance;
        bulletInstance = Instantiate(bulletPrefab, Point.position, Point.rotation) as Rigidbody2D;
        bulletInstance.velocity = Point.up * bulletSpeed;
    }

}
