using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float xHorizontal;
    [SerializeField] float yVertical;

    Rigidbody2D rb;
    Vector3 movementAxis;

    void Start()
    {
        movementAxis = new Vector3(xHorizontal, yVertical, 0);
        rb = GetComponent<Rigidbody2D>(); 
    }

    void FixedUpdate()
    {
        Vector3 addedPosition = (movementAxis * moveSpeed * Time.fixedDeltaTime);
        rb.MovePosition(transform.position + addedPosition);
    }

}
