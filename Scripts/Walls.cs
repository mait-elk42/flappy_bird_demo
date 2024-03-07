using UnityEngine;

public class Walls : MonoBehaviour
{
    int time;
    public GameObject wall_origin;
    private Vector2 spawn_pos;
    void Awake()
    {
        time = 500;
        spawn_pos = transform.position;
    }

    void Update()
    {
        if (time <= 0)
        {
            spawn_pos.y = Random.Range(-2.5f, 0.5f);
            Instantiate(wall_origin, spawn_pos, Quaternion.identity);
            time = 2000;
        }
        time--;
    }

}
