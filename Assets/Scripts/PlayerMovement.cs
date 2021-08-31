using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.Translate(Vector3.right * speed);
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 1);
    }
}
