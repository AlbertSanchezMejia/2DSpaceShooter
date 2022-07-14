using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_MoveInCurve : MonoBehaviour
{
    [SerializeField] float curveDistance = 2;
    [SerializeField] float curveSpeed = 0.5f;
    float curveCenteX;

    void Start()
    {
        curveCenteX = transform.position.x;
    }

    void Update()
    {
        Vector2 pos = transform.position;

        float curve = Mathf.Sin(pos.y * curveSpeed) * curveDistance;
        pos.x = curveCenteX + curve;

        transform.position = pos;
    }

}
