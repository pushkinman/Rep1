using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarMovement : MonoBehaviour
{
    private float _speed;
    private float _finishRoadPositionZ = -10;
    
    // Start is called before the first frame update
    void Start()
    {
        _speed = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * (_speed * Time.deltaTime));
        CheckIfVisible();
    }

    private void CheckIfVisible()
    {
        if (transform.position.z < _finishRoadPositionZ)
        {
            Destroy(gameObject);
        }
    }
}
