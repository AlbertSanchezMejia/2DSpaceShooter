using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    [SerializeField] float bulletsSpeed = 10f;
    [SerializeField] float shootDelay = 0.5f;
    [SerializeField] Rigidbody2D bulletPrefab;
    [SerializeField] Transform spawnPoint;
    bool _canShoot;

    void Start()
    {
        _canShoot = true;
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && _canShoot == true)
        {
            StartCoroutine(Co_ShootBullets());
        }
    }

    IEnumerator Co_ShootBullets()
    {
        _canShoot = false;
        ShootBullets();

        yield return new WaitForSeconds(shootDelay);

        _canShoot = true;
    }

    void ShootBullets()
    {
        Rigidbody2D bulletInstance;
        bulletInstance = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation) as Rigidbody2D;
        bulletInstance.velocity = spawnPoint.up * bulletsSpeed;
    }

}
