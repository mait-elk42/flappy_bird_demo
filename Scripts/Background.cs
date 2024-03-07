using UnityEngine;

public class Background : MonoBehaviour
{
    public Sprite sprite;
    public bool wallpaper_running;
    private GameObject bg1;
    private GameObject bg2;
    private Vector3 bg1pos;
    private Vector3 bg2pos;
    void Awake()
    {
        wallpaper_running = false;
        bg1 = transform.GetChild(0).gameObject;
        bg2 = transform.GetChild(1).gameObject;
        bg1.GetComponent<SpriteRenderer>().sprite = sprite;
        bg2.GetComponent<SpriteRenderer>().sprite = sprite;
        bg1pos = bg1.transform.position;
        bg2pos = bg2.transform.position;
    }
    void Start()
    {

    }

    void Update()
    {
        if (wallpaper_running == false)
            return;
        bg1pos.x -= Time.deltaTime;
        bg2pos.x -= Time.deltaTime;
        if (bg1pos.x <= -5.0f)
            bg1pos.x = 5.0f;
        if (bg2pos.x <= -5.0f)
            bg2pos.x = 5.0f;
        bg1.transform.position = bg1pos;
        bg2.transform.position = bg2pos;
    }
}
