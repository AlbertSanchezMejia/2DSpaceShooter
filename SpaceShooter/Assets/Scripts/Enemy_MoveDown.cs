using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_MoveDown : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void FixedUpdate()
    {
        Vector3 addedPosition = (-transform.up * moveSpeed * Time.fixedDeltaTime);
        rb.MovePosition(transform.position + addedPosition);
    }

}
