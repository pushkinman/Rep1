using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadTileMovement : MonoBehaviour
{
    public static float speed = 0.1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.back * speed);
    }
}
