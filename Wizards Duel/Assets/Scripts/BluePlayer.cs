using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayer : MonoBehaviour
{
    
    [SerializeField] private float speed = 3f;
    [SerializeField] private float rotateSpeed = 3f;


    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move();
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveBack();
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float angle = transform.eulerAngles.z;
            transform.Rotate(0, 0, rotateSpeed * 1f * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
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