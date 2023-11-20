using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Ball : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rb;
    public int destroyTimer = 0;
    public GameObject RedPanel;
    public GameObject BluePanel;


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

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.CompareTag("Red Player"))
        {
            SceneManager.LoadScene(4);
        }
        
        if (col.collider.CompareTag("Blue Player"))
        {
            SceneManager.LoadScene(3);
        }
    }
    
}

    
