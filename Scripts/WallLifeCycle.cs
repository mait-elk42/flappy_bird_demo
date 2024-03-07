using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLifeCycle : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x <= -4)
            Destroy(gameObject);
        transform.Translate(Vector2.left * Time.deltaTime);
    }
}
