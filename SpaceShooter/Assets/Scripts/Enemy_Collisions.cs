using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Collisions : MonoBehaviour
{
    [SerializeField] int enemyLife;
    public GameObject explosionParticles;
    bool play = false;

    void SubstractLife()
    {
        enemyLife--;
    }

    void DesactivateObject()
    {
        if (enemyLife <= 0)
        {
            Instantiate(explosionParticles, transform.position, transform.rotation);

            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet") && play == false)
        {
            SubstractLife();
            DesactivateObject();
        }
    }

}
