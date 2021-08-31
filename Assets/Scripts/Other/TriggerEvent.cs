using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    private void OnTriggerStay(Collider other)
    {
        gameObject.transform.Rotate(Vector3.up);
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
