using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_EnemiesActivate : MonoBehaviour
{
    [SerializeField] float[] waitTime;
    [SerializeField] GameObject[] enemiesGroup;
    int i = 0;

    void Start()
    {
        Invoke(nameof(ActivateEnemies), waitTime[i]);
    }

    void ActivateEnemies()
    {
        enemiesGroup[i].SetActive(true);
        i++;
        if(i >= waitTime.Length)
        {
            return;
        }
        Invoke(nameof(ActivateEnemies), waitTime[i]);
    }

}
