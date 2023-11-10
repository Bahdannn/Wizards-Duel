using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rb;
    public int destroyTimer = 0;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    void Start()
    {
        
        _rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
        Invoke("DestroyBall", 6f);
    }
    
    void Update()
    {
        
    }

    private void DestroyBall()
    {
        Destroy(this.gameObject);
    }
}
