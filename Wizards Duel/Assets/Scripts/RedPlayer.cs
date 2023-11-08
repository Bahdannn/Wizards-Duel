using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : MonoBehaviour
{
    
    [SerializeField] private float speed = 3f;
    [SerializeField] private float rotateSpeed = 3f;


    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Move();
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            MoveBack();
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            float angle = transform.eulerAngles.z;
            transform.Rotate(0, 0, rotateSpeed * 1f * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            float angle = transform.eulerAngles.z;
            transform.Rotate(0, 0, rotateSpeed * -1f * Time.deltaTime);
        }
    }

    private void MoveBack()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

    }

    private void Update()
    {
        
    }

    private void Move()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
