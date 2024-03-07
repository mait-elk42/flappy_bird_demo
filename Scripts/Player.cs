using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject wmsg;
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
        if (transform.position.y <= -4.5f)
            OnDie();
        if (Input.GetKeyDown(KeyCode.Space))
            OnClickScreen();
    }

    public void OnClickScreen()
    {
        if (alive)
            rb.velocity = Vector2.up * 5;
        print("jump!");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
            OnDie();
    }
    void    OnDie()
    {
        print("Game Over!");
        alive = false;
        Time.timeScale = 0;
    }
}
