using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Death : MonoBehaviour
{
    [SerializeField] int playerLife;

    void SubstractLife()
    {
        playerLife--;
    }

    void DesactivateObject()
    {
        if (playerLife <= 0)
        {
            RestartScene();
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SubstractLife();
            DesactivateObject();
        }
    }

}
