using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_MoveDown : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody2D rb;

    void FixedUpdate()
    {
        rb.MovePosition(transform.up * -1 * moveSpeed * Time.fixedDeltaTime);
    }

}
