using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_MoveInCurve : MonoBehaviour
{
    [SerializeField] float curveDistance = 2;
    [SerializeField] float curveSpeed = 0.5f;
    [SerializeField] bool isVertical;
    float curveCenter;
    void Start()
    {
        if(isVertical) curveCenter = transform.position.x;
        else curveCenter = transform.position.y;
    }

    void Update()
    {
        Vector2 pos = transform.position;
        if (isVertical)
        {
            float curve = Mathf.Sin(pos.y * curveSpeed) * curveDistance;
            pos.x = curveCenter + curve;
        }
        else
        {
            float curve = Mathf.Sin(pos.x * curveSpeed) * curveDistance;
            pos.y = curveCenter + curve;
        }


        transform.position = pos;
    }

}
