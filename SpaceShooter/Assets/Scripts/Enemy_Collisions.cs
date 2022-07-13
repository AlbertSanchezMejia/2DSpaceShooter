using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Collisions : MonoBehaviour
{
    [SerializeField] int enemyLife;

    void SubstractLife()
    {
        enemyLife--;
    }

    void DesactivateObject()
    {
        if (enemyLife <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            SubstractLife();
            DesactivateObject();
        }
    }

}
