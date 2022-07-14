using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets_Collisions : MonoBehaviour
{
    void DesactivateObject()
    {
        gameObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        DesactivateObject();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        DesactivateObject();
    }

}
