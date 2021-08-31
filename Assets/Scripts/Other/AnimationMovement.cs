using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMovement : MonoBehaviour
{
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _animator.SetBool("MoveRight", true);
        }
        else
        {
            _animator.SetBool("MoveRight", false);

        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _animator.SetBool("MoveLeft", true);
        }
        else
        {
            _animator.SetBool("MoveLeft", false);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            _animator.SetTrigger("New Trigger");
        }
    }
}
