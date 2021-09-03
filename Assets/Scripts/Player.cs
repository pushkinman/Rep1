using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    private const float ROAD_STEP = 3.3f;
    private Animator _animator;
    public CarState state = CarState.Middle;

    public enum CarState
    {
        Middle,
        Right,
        Left
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        CheckInput();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.Translate(Vector3.up * Time.deltaTime);
        }
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && (state == CarState.Left || state == CarState.Middle))
        {
            _animator.SetTrigger("MoveRight");
            UpdateStateRight();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (state == CarState.Right || state == CarState.Middle))
        {
            _animator.SetTrigger("MoveLeft");
            UpdateStateLeft();
        }
    }
    
    bool IsPlaying(Animator anim, string stateName)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName(stateName) &&
            anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }

    private void UpdateStateRight()
    {
        if (state == CarState.Left)
        {
            state = CarState.Middle;
            return;
        }

        if (state == CarState.Middle)
        {
            state = CarState.Right;
        }
    }
    
    private void UpdateStateLeft()
    {
        if (state == CarState.Right)
        {
            state = CarState.Middle;
            return;
        }

        if (state == CarState.Middle)
        {
            state = CarState.Left;
        }
    }

    private void FixPositionAndRotation()
    {
        transform.rotation = Quaternion.Euler(0,0,0);
        if (transform.position.x > 1)
        {
            transform.position = new Vector3(ROAD_STEP, 0, 0);
        } 
        else if (transform.position.x < -1)
        {
            transform.position = new Vector3(-ROAD_STEP, 0, 0);
        }
        else
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
//new comment
    private void OnTriggerEnter(Collider other)
    {
        //gameObject.SetActive(false);
    }
}
