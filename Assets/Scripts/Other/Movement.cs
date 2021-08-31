using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _rigidbody.AddForce(Vector3.forward * 50);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            _rigidbody.AddForce(Vector3.left * 50 );
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _rigidbody.AddForce(Vector3.back * 50);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _rigidbody.AddForce(Vector3.right * 50);
        }
    }
}
