using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    void Start()
    {
        
        _rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
    }
    
    void Update()
    {
        //transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
