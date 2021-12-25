using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{

    private float startPosition, len;
    public float effect;
    public GameObject camera;

    void Start()
    {
        startPosition = transform.position.x;
        len = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    void FixedUpdate()
    {
        float distance = effect * camera.transform.position.x;
        float temp = (1-effect) * camera.transform.position.x;
        transform.position = new Vector2(startPosition+distance, transform.position.y);

        if(temp > startPosition+len)
        {
            startPosition+=len;
        }
        else if (temp< startPosition-len)
        {
            startPosition-=len;
        }
    }
}
