using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool alive;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        alive = true;
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            OnClickScreen();
    }

    public void OnClickScreen()
    {
        if (alive)
            rb.velocity = Vector2.up * 6;
    }
}
